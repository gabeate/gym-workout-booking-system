using System.Globalization;
using System.Text.RegularExpressions;

namespace GymWorkoutFormProject
{
    public class Member
    {
        private int memberID;
        private string memberName;
        private string phoneNumber;
        private string emailAddress;
        private string password;

        public Member()
        {
            memberName = "";
            phoneNumber = "";
            emailAddress = "";
            password = "";
        }

        public Member(int memberID, string memberName, string phoneNumber, string emailAddress, string password)
        {
            this.memberID = memberID;
            this.memberName = memberName;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.password = password;
        }

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}