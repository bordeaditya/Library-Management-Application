using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApplication.LibClass
{
    class Constants
    {
        #region String Constants
        public static string NoCriteria = "Specify atleast single criteria to search.";
        public static string ErrorInSearch = "Error in Serach";
        public static string NewBRAdded = "New Borrower Added Successfully with Card Number = ";

        public static string DuplicateBR = "Borrower Already Exists.";
        public static string RequiredFields = "Required Marked(*) field must be filled.";
        public static string Error = "Error Occured. ";
        public static string NoBorrower = "Borrower does not Exist.";

        public static string NoBook = "Sorry. No Book Copy is Available.";
        public static string BookIssued = "Book issued Successfully to Card Number = ";
        public static string ErrorInIssuing = "Error : In Book Issue.";

        public static string ThreeCopies = " have already three copies Issued.";
        public static string CardNumber = "Card Number : ";
        public static string NoRecordFound = "No Such Record is found.";
        public static string Pattern = "{0:(###) ###-####}";
        public static string DefaultCardNo = "0";
        public static string DateFormat = "MM/dd/yyyy";
        public static string IncorrectDate = "Date is in incorrect format";
        public static string CheckInSuccessful = " Books Checked in successfully.";
        public static string NoReord = "No book is selected to check in.";

        public static string FinesUpdateSuccessful = "Fines updated Successfully.";
        public static string FinesCardnumberIndex = "FinesCardNo";


        public static string CheckInCardnumberIndex = "Card_no";
        public static string CardNumberBlank = "Card Number shouldn't be blank.";
        public static string BorrowerNameBlank = "Borrower Name shouldn't be blank.";
        public static string PaymentComplete = " Item Payment Done Successfully.";
        public static string NoRecordSelected = "No Record Selected.";

        public static string FinesBookIdIndex = "FinesBookId";
        public static string FinesBranchIdIndex = "FinesBranchId";
        public static string FinesLoanIdIndex = "FinesLoanId";
        public static string FinesFineAmountIndex = "FinesFineAmount";
        public static string FinesCheckBoxIndex = "Payment";

        public static string PaymentConfirm = "Click 'Yes' to Confirm the payment = ";
        public static string PaymentConfirmDialog = "Payment Confirmation";
        public static string Dollars = " $ ";
        public static string Returned = "Returned";
        public static string PendingFines = "You Have pending fines.";
        public static string ManualPage ="http://www.utdallas.edu/~asb140930/Manual/Manual.pdf";
        public static string SameCopyCheckOut = "Borrower already has same book copy.";
        #endregion 

        #region Integer Constansts
        public static int DateInWidth = 110;
        public static int MaxCopies = 3;
        public static int MinCopies = 1;
        public static int MaximumCharacters = 10;
        public static int MinimumCharacters = 0;
        public static int CheckBoxIndex = 0;
        public static int CardNoIndex = 3;
        public static int DateInIndex = 6;
        public static int BookIdInddex = 1;
        public static int BranchIdInddex = 2;
        public static int DisplayTime = 10000;// 10 Seconds
        public static int DefaultCardNumberValue = 0;

        public static int FinesCardNumberIndex = 5;

        public static int Index0 = 0;
        public static int Index1 = 1;
        public static int Value0 = 0;
        #endregion

        #region Char Constants
        public static char PaddingChar = '0';
        public static char SeperationChar = '-';
        #endregion

    }
}
