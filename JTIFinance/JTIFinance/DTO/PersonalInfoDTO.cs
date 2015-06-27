using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace JTIFinance.DTO
{
    /*
     * @author: Vikum Sam
     * @Date: 23/06/15
     * 
     * This is Data Transfer Objecct Class for 'invaccinfo' table
         * */

    public class PersonalInfoDTO
    {
        
        private string cusID;
        private string cusFullName;
        private string cusUseName;
        private string cusNicNo;
        private string cusAddress;
        private string cusRoadDescrip;
        private string gageType;
        private string notes;
        private  List<InvBranchesDTO> branch;
        private int status; 
        private int cusContact1;
        private int cusContact2;

        /*
         * These are the Getter Methods for the above private Fields
         * */

        public string getCusFullName(){return this.cusFullName;}
        public string getCusUseName(){return this.cusUseName;}
        public string getCusNicNo(){return this.cusNicNo;}
        public string getCusAddress(){return this.cusAddress;}
        public string getCusRoadDescriptions(){return this.cusRoadDescrip;}
        public string getGageType(){return this.gageType;}
        public string getNotes(){return this.notes;}
        public int getStatus(){return this.status;}

        public int getContact1(){return this.cusContact1;}
        public int getContact2(){return this.cusContact2;}

        /*
         * These are the Setter Methods for the above private Fields
         * */
        public void setCusFullName(string cusFullName){this.cusFullName=cusFullName;}
        public void setCusUseName(string cusUseName){this.cusUseName=cusUseName;}
        public void setCusNicNo(string cusNicNo){this.cusNicNo=cusNicNo;}
        public void setCusAddress(string cusAddress){this.cusAddress=cusAddress;}
        public void setCusRoadDescriptions(string cusRoadDescription) { this.cusRoadDescrip = cusRoadDescription; }
        public void setGageType(String gageType){this.gageType=gageType;}
        public void setNotes(string notes){this.notes=notes;}
        public void setStatus(int status){this.status=status;}
        public void setCusContact1(int cusContact1){this.cusContact1=cusContact1;}
        public void setCusContact2(int cusContact2){this.cusContact2=cusContact2;}



    }
}
