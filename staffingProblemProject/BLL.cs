using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using staffingProblemProject.DLTableAdapters;
using System.Data;

namespace staffingProblemProject
{
    public class BLL
    {
        tblAdminTableAdapter adminObj = new tblAdminTableAdapter();
        tblMembersTableAdapter memberObj = new tblMembersTableAdapter();
        
        tblUsersTableAdapter userObj = new tblUsersTableAdapter();
        tblJobAdsTableAdapter adsObj = new tblJobAdsTableAdapter();

        tblApplyJobsTableAdapter applyObj = new tblApplyJobsTableAdapter();
        tblMLParamsTableAdapter MLParamsObj = new tblMLParamsTableAdapter();
        #region ----- User Account -----

        //function to check the receipt number
        public bool CheckReceiptNumber(string receiptNo)
        {
            int cnt = int.Parse(memberObj.CheckReceiptNumber(receiptNo).ToString());

            if (cnt == 1)

                return false;

            return true;
        }

        //function to check administrator login (adminid & password)
        public bool CheckAdminLogin(string adminId, string password)
        {
            int cnt = int.Parse(adminObj.CheckAdminLogin(adminId, password).ToString());

            if (cnt == 1)

                return true;

            return false;
        }

        //function to check member login (memberid & password)
        public bool CheckMemberLogin(string memberId, string password,string status)
        {
            int cnt = int.Parse(memberObj.CheckMemberLogin(memberId, password,status).ToString());

            if (cnt == 1)

                return true;

            return false;
        }

        //function to check the member id (exists/does'nt exists)
        public bool CheckMemberId(string memberId)
        {
            int cnt = int.Parse(memberObj.CheckMemberId(memberId).ToString());

            if (cnt == 1)

                return false;

            return true;

        }

        //function to the new member registration
        public void InsertMemberr(string memberId, string password, string Name, string compnayName, string Address, string phone, string emailId, string logo,string receiptNUmber, string registerDate,string status)
        {
            memberObj.InsertMember(memberId, password, Name, compnayName, Address, phone, emailId, logo,receiptNUmber, registerDate, status);
        }

        //function to get member details based on member id
        public DataTable GetMemberById(string memberId)
        {
            return memberObj.GetMemberById(memberId);
        }

        //function to get the admin details based on admin Id
        public DataTable GetAdminById(string adminId)
        {
            return adminObj.GetAdminById(adminId);
        }

        //function to update the administrator password
        public void UpdateAdminPassword(string password, string adminId)
        {
            adminObj.UpdateAdminPassword(password, adminId);
        }

        //function to update the member password
        public void UpdateMemberPassword(string password, string memberId)
        {
            memberObj.UpdateMemberPassword(password, memberId);
        }

        //function to update member profile
        public void UpdateMemberProfile(string name, string address, string contactNo, string emailId, string logo, string memberId)
        {
            memberObj.UpdateMember(name, address, contactNo, emailId, logo, memberId);
        }

        //function to update member profile
        public void UpdateMProfile(string Id, string name,string cname, string address, string contactNo, string emailId, string memberId)
        {
            memberObj.UpdateMProfile(Id, name, cname, address, contactNo, emailId, memberId);
        }

        #endregion

        #region ----- Member Verification -----

        //function to get members based on status
        public DataTable GetUsersByStatus(string status)
        {
            return memberObj.GetMembersByStatus(status);
        }

        //function to delete member based on id
        public void DeleteMember(string memberId)
        {
            memberObj.DeleteMember(memberId);
        }

        //function to update the user status
        public void UpdateStatus(string status, string memberId)
        {
            memberObj.UpdateStatus(status, memberId);
        }

        #endregion

       
        //function to register new user
        public void NewUser(string userId, string password, string name, string address, string mobile, string emailId, string resume, string skills, string date)
        {
            userObj.NewUser(userId,password, name, address, mobile, emailId, resume, skills, date);
        }

        public void UpdateUser(string userId, string name, string address, string mobile, string emailId, string resume, string skills, string date)
        {
            userObj.UpdateUser(userId, name, address, mobile, emailId, resume, skills, date, userId);
        }

        //function to fetch all users
        public DataTable GetAllUsers()
        {
            return userObj.GetData();
        }

        //function to delete the user
        public void DeleteUser(string userid)
        {
            userObj.DeleteUser(userid);
        }

        //function to check candidate login (userid & password)
        public bool CheckUserLogin(string userId, string password)
        {
            int cnt = int.Parse(userObj.CheckUserLogin(userId, password).ToString());

            if (cnt == 1)

                return true;

            return false;
        }

        //function to check the user id (exists/does'nt exists)
        public bool CheckUserId(string userId)
        {
            int cnt = int.Parse(userObj.CheckUserId(userId).ToString());

            if (cnt == 1)

                return false;

            return true;

        }

        //function to update the candidate password
        public void UpdateCandidatePassword(string password, string adminId)
        {
            userObj.UpdateCandidatePassword(password, adminId);
        }

        public DataTable GetUserById(string Id)
        {
            return userObj.GetUserById(Id);
        }


        //function to add new ads
        public void InsertNewAd(string memberId, string jobType, string subType, string skills, string desc, DateTime date, string status)
        {
            adsObj.NewAds(memberId, jobType, subType, skills, desc, date, status);
        }


        public void UpdateAds(string memberId, string jobType, string subType, string skills, string desc, DateTime date, string status, int adId)
        {
            adsObj.UpdateAds(memberId, jobType, subType, skills, desc, date, status, adId);
        }

        public DataTable GetAdsByCompany(string memberId)
        {
            return adsObj.GetAdsByCompany(memberId);
        }

        public DataTable GetAdsById(int adsId)
        {
            return adsObj.GetAdsById(adsId);
        }

        public void DeleteAd(int AdId)
        {
            adsObj.DeleteAds(AdId);
        }

        public void DeleteApplyJobsByAd(int AdId)
        {
            applyObj.DeleteApplyJobsByAdsId(AdId);
        }

        public void DeleteJobApplication(string userId, int adId)
        {
            applyObj.DeleteJobApplication(userId, adId);
        }

        public DataTable GetAllAds()
        {
            return adsObj.GetData();
        }

        public DataTable GetAllNewAds()
        {
            return adsObj.GetAllNewAds();
        }

        public DataTable GetJobAdsByType(string type)
        {
            return adsObj.GetJobAdsByType(type);
        }


        public DataTable GetAdsByUserId(string userId)
        {
            return applyObj.GetAdsByUserId(userId);
        }

        public DataTable GetCandidatesByAdId(int adId)
        {
            return applyObj.GetCandidatesByAdId(adId);
        }

        public DataTable GetApplication(string userId, int adId)
        {
            return applyObj.GetApplication(userId, adId);
        }

        public DataTable GetCandidatesByAdIdApplied(int adId)
        {
            return applyObj.GetCandidatesByAdIdApplied(adId);
        }

        public DataTable GetCandidatesByAdIdShortOrOffered(int adId)
        {
            return applyObj.GetCandidatesByAdIdShortOrOffered(adId);
        }

        public void InsertApplyJob(string userId, int adId, string status)
        {
            applyObj.InsertApplyJob(userId, adId, status);
        }

        public void UpdateApplicationStatus(string userId, int adId, string status)
        {
            applyObj.UpdateApplicationStatus(status, userId, adId);
        }

        public bool CheckUserAd(string userId, int adId)
        {
            int cnt = int.Parse(applyObj.CheckUserAd(userId, adId).ToString());

            if (cnt == 1)

                return false;

            return true;
        }

        public DataTable GetMLParamsById(string userId)
        {
            return MLParamsObj.GetMLParamsById(userId);
        }
        public bool CheckMLParams(string userId)
        {
            int cnt = int.Parse(MLParamsObj.CheckMLParams(userId).ToString());

            if (cnt == 1)

                return false;

            return true;
        }
        public void InsertMLParams(string userID, int sslc, int puc, int comms, int ps, int networks, int sysDesign, int vcs, int jsts, int java, int dbms, int dsa, int os, int cloud, int containers, int math, int python, int ccpp)
        {
            MLParamsObj.InsertMLParams(userID, sslc, puc, comms, ps, networks, sysDesign, vcs, jsts, java, dbms, dsa, os, cloud, containers, math, python, ccpp);
        }
        public void UpdateMLParams(string userID, int sslc, int puc, int comms, int ps, int networks, int sysDesign, int vcs, int jsts, int java, int dbms, int dsa, int os, int cloud, int containers, int math, int python, int ccpp)
        {
            MLParamsObj.UpdateMLParams(userID, sslc, puc, comms, ps, networks, sysDesign, vcs, jsts, java, dbms, dsa, os, cloud, containers, math, python, ccpp, userID);
        }
    }
}