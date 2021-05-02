using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.GenericRepository;
using DataAccess.Context;
using DataAccess.Entity;
using System.Data.SqlClient;
using System.Data;

namespace BusniessLogic.SpecificRepository
{
    public class ComplaintRepository:IComplaint
    {
        public void SaveComplaint(Complaint C)
        {
            IGeneric<Complaint> obj = new Generic<Complaint>();
            obj.Save(C);
            obj.SaveChanges();
        }

        public void UpdateComplaintStatus(int ComplaintID, int StatusID)
        {
            ComplaintContext Con = new ComplaintContext();
            Complaint obj = new Complaint();
            obj = Con.Complaint.Find(ComplaintID);
            obj.ComplaintStatusID = StatusID;

            Con.SaveChanges();
        }

        public List<Complaint> LoadComplaintsWithDetails()
        {
            ComplaintContext Con = new ComplaintContext();
            Complaint Comp = new Complaint();
            List<Complaint> LiComplaint = new List<Complaint>();
            var Data = Con.Complaint.Select(a => new
            {
                ComplaintID = a.ID,
                ComplaintTitle = a.Title,
                ComplaintDesc = a.Description,
                ComplaintEntryDate = a.EntryDate,
                ComplaintType=a.CTRef.Name,
                ComplaintStatus=a.CSRef.Name,
                ComplaintUserName = a.ProfileRef.UserName            
            });

            foreach(var a in Data)
            {
                Comp = new Complaint();
                Comp.ID = a.ComplaintID;
                Comp.Title = a.ComplaintTitle;
                Comp.Description = a.ComplaintDesc;
                Comp.EntryDate = a.ComplaintEntryDate;
                Comp.ComplaintType = a.ComplaintType;
                Comp.ComplaintStatus = a.ComplaintStatus;
                Comp.UserName = a.ComplaintUserName;
                LiComplaint.Add(Comp);
            }

            return LiComplaint;
        }

        public List<Complaint> LoadComplaintWithDetailsByProfileID(int ProfileID)
        {
            ComplaintContext Con = new ComplaintContext();
            Complaint Comp = new Complaint();
            List<Complaint> LiComplaint = new List<Complaint>();
            var Data = Con.Complaint.Where(a=>a.ProfileID == ProfileID).Select(a => new
            {
                ComplaintID = a.ID,
                ComplaintTitle = a.Title,
                ComplaintDesc = a.Description,
                ComplaintEntryDate = a.EntryDate,
                ComplaintType = a.CTRef.Name,
                ComplaintStatus = a.CSRef.Name,
                ComplaintUserName = a.ProfileRef.UserName
            });

            foreach (var a in Data)
            {
                Comp = new Complaint();
                Comp.ID = a.ComplaintID;
                Comp.Title = a.ComplaintTitle;
                Comp.Description = a.ComplaintDesc;
                Comp.EntryDate = a.ComplaintEntryDate;
                Comp.ComplaintType = a.ComplaintType;
                Comp.ComplaintStatus = a.ComplaintStatus;
                Comp.UserName = a.ComplaintUserName;
                LiComplaint.Add(Comp);
            }

            return LiComplaint;
        }

        public Complaint LoadComplaintByComplaintID(int Complaintid)
        {
            ComplaintContext Con = new ComplaintContext();
            Complaint obj = new Complaint();
            obj = Con.Complaint.Where(a => a.ID == Complaintid).SingleOrDefault();

            return obj;
        }
    }
}
