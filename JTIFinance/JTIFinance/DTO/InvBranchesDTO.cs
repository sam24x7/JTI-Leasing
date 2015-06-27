using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTIFinance.DTO
{
    /*
     *   DTO class for Branches Table
     *   @Created By: Vikum Sam
     *   @Date: 25/06/15
     * 
     * */
     
    class InvBranchesDTO
    {
        private int branchID;
        private string branchName;
        private string branchAddress;
        private string branchManager;
        private DateTime createdDate;
        private int status;
        private string notes;
        private List<PersonalInfoDTO> personalInfo;

        /*
         * These are Getter Methods for the InvBranchesDTO Object
         * 
         * */
        public int getBranchID() { return this.branchID; }
        public string getBranchName() { return this.branchName; }
        public string getBranchAddress() { return this.branchAddress;}
        public string getBranchManager() { return this.branchManager; }
        public DateTime getCreatedDate() { return this.createdDate; }
        public int getStatus() { return this.status; }
        public string getNotes() { return this.notes; }

        /*
         * These are setter Methods for the InvBranchesDTO Object
         * 
         * */
        
        public void setBranchID(int branchID){this.branchID=branchID;}
        public void setBranchName(string branchName){this.branchName=branchName;}
        public void setBranchAddress(string branchAddress){this.branchAddress=branchAddress;}
        public void setBranchManager(string branchManager){this.branchManager=branchManager;}
        public void setCreatedDate(DateTime createdDate){this.createdDate=createdDate;}
        public void setStatus(int status){this.status=status;}
        public void setNotes(string notes) { this.notes = notes; }

    }
}
