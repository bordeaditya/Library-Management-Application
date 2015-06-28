using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Data.Entity;
using LibraryApplication.SqlLayer;

namespace LibraryApplication.SqlLayer
{
    public class DataLayer
    {
        #region User Authetication
        /// <summary>
        /// Check The User Details in DB
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public bool CheckUserDetails(string userId, string password)
        {
            bool result = true;
            string userId_, password_;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    userId_ = userId.Trim().ToLower();
                    password_ = password.Trim().ToLower();
                    int users = (from user in entity.tblUsers
                                 where user.User_id == userId_ && user.Password == password_
                                 select user).Count();

                    if (users > 0)
                        result = true;
                    else
                        result = false;
                }
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }
        #endregion

        #region Book Availability
        /// <summary>
        /// Get Book search data
        /// </summary>
        /// <param name="book_id">Book Id</param>
        /// <param name="title">Title</param>
        /// <param name="author">Author</param>
        public List<uspGetBookInfo_Result> GetBookSearchData(string book_id, string title, string author,string role)
        {
            List<uspGetBookInfo_Result> bookInfo;
            List<uspGetBookInfo_Result> finalBookInfo;
            uspGetBookInfo_Result bookAuthorItem;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    string author_ = string.Empty;
                    bool flag = true;
                    bookInfo = new List<uspGetBookInfo_Result>();
                    bookInfo = entity.uspGetBookInfo(book_id,title,author,role).ToList();

                    //Grouping Authors into one By , Seperation.
                    finalBookInfo = new List<uspGetBookInfo_Result>();
                    //finalBookInfo = bookInfo.Zip
                    var bookInfoById = (from bookInfoItem in bookInfo
                                     group bookInfoItem by new { bookInfoItem.Book_id,bookInfoItem.Branch_id} into newBookInfo
                                     select newBookInfo);

                    // For Each Group Get the Information
                    foreach (var bookAuthors in bookInfoById)
                    {
                        bookAuthorItem = new uspGetBookInfo_Result();
                        author_ = string.Empty;
                        flag = true;
                        // Append the Author by , Seperation
                        foreach (uspGetBookInfo_Result item in bookAuthors)
                        {
                            author_ = author_ + item.Author_name + " ,";
                            #region fill the object from DB
                            // To fill the Object only at Once.
                            if (flag)
                            {
                                bookAuthorItem.Book_id = item.Book_id;
                                bookAuthorItem.Title = item.Title;
                                bookAuthorItem.Branch_id = item.Branch_id;
                                bookAuthorItem.No_of_copies = item.No_of_copies;
                                bookAuthorItem.No_of_Available_copies = item.No_of_Available_copies;
                                bookAuthorItem.Branch_name = item.Branch_name;
                                bookAuthorItem.Role = item.Role;
                                flag = false;
                            }
                            #endregion
                        }
                        author_ = author_.Remove(author_.Length - 1, 1);
                        bookAuthorItem.Author_name = author_;
                        finalBookInfo.Add(bookAuthorItem);
                    }
                }
                return finalBookInfo;
            }
            catch (Exception e){
                finalBookInfo = new List<uspGetBookInfo_Result>();
                finalBookInfo[0].Author_name = "Error:" + e.Message;
                return finalBookInfo;
            }
        }
        #endregion

        #region Book_CheckOut
        /// <summary>
        /// Verify Library Card Holders Information
        /// </summary>
        /// <param name="cardNumber">Card Number</param>
        /// <returns></returns>
        public bool IsCardNoExists(int cardNumber)
        {
            uspGetCardNoInfo_Result cardInfo;
            bool result = false;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    cardInfo = new uspGetCardNoInfo_Result();
                    cardInfo = entity.uspGetCardNoInfo(cardNumber).FirstOrDefault();
                    if (cardInfo != null)
                        result = true;
                    else
                        result = false;
                    return result;
                }
            }
            catch (Exception e)
            {
                result = false;
                return result;
            }
        }

        /// <summary>
        /// Get the Available Books at particular branch and its Count
        /// </summary>
        /// <param name="bookId">BOOK ID</param>
        /// <param name="branchId">Branch ID</param>
        /// <returns></returns>
        public int GetAvailableBooks(string bookId, int branchId)
        {
            int availableCopies;
            uspGetAvailableBookCountAtBranch_Result availableBooks;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    string bookId_ = bookId.Trim();
                    availableBooks = new uspGetAvailableBookCountAtBranch_Result();
                    availableBooks = entity.uspGetAvailableBookCountAtBranch(bookId_, branchId).FirstOrDefault();
                    availableCopies = Convert.ToInt32(availableBooks.AvailableCopies);
                }
                return availableCopies;
            }
            catch (Exception e)
            {
                availableCopies = -1;
                return availableCopies;
            }
        }

        /// <summary>
        /// Get Total books issued by particular user
        /// </summary>
        /// <param name="cardno">Card Number</param>
        /// <returns></returns>
        public int GetCardNoBookIssuedCount(int cardno)
        {
            int totalBooksIssued = -1;
            try {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    totalBooksIssued = (from bookLoans in entity.tblBOOK_LOANS where bookLoans.Card_no == cardno
                                 && bookLoans.Date_in == null select bookLoans).Count();
                }
                return totalBooksIssued;
            }
            catch(Exception e)
            {
                int error = -1;
                return error;
            }
        }

        /// <summary>
        /// Check if card number already holds same book copy.
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public bool IsSameCopyCheckedOut(int cardNumber,string bookId)
        {
            bool result = false;
            int count =0;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    count = (from bookLoans in entity.tblBOOK_LOANS
                             where bookLoans.Card_no == cardNumber && bookLoans.Book_id == bookId
                             && bookLoans.Date_in == null
                             select bookLoans).Count();

                    if (count > 0)
                        result = true;
                    else
                        result = false;
                }
                return result;
            }
            catch (Exception e)
            {
                result = true;
                return result;
            }
        }

        /// <summary>
        /// Add New Book Loan Touple to Database And Fines.
        /// </summary>
        /// <param name="bookId">Book Id</param>
        /// <param name="branchId">Branch Id</param>
        /// <param name="cardNumber">Card Number</param>
        /// <param name="dateOut">Date Out</param>
        /// <param name="dueDate">Due Date</param>
        public bool AddNewBookLoanAndFines(string bookId,int branchId,int cardNumber,DateTime dateOut,DateTime dueDate)
        {
            tblBOOK_LOANS bookLoans;
            tblFINE fines;
            bool result;
            int newLoanId;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    #region Add New Book Loans
                    bookLoans = new tblBOOK_LOANS();
                    bookLoans.Book_id = bookId.Trim();
                    bookLoans.Branch_id = branchId;
                    bookLoans.Card_no = cardNumber;
                    bookLoans.Date_out = dateOut;
                    bookLoans.Due_date = dueDate;
                    entity.AddTotblBOOK_LOANS(bookLoans);
                    entity.SaveChanges();

                    newLoanId = (from latest in entity.tblBOOK_LOANS
                                 where latest.Book_id == bookId.Trim() && latest.Branch_id == branchId
                                 && latest.Card_no == cardNumber
                                 select latest.Loan_id).FirstOrDefault();
                    #endregion

                    #region Add New Fines
                    fines = new tblFINE();
                    fines.Book_id = bookId.Trim();
                    fines.Loan_id = newLoanId;
                    fines.paid = true;
                    fines.Fine_amount = 0;
                    fines.Branch_id = branchId;
                    entity.AddTotblFINES(fines);
                    entity.SaveChanges();
                    #endregion
                    result = true;
                }
                return result;
            }
            catch (Exception e)
            {
                result = false;
                return result;                
                // Exception In Entity
            }
        }
        #endregion
        
        #region Book_CheckIn
        /// <summary>
        /// Update Book copies Issued Count and date In
        /// </summary>
        /// <param name="bookId">Book Id</param>
        /// <param name="branchId">Branch Id</param>
        public bool UpdateIssuedCopiesCountDateInDetails(string bookId, int branchId,int cardNumber,DateTime dateIn)
        {
            bool result = true;
            tblBOOK_LOANS bookLoans;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    string bookId_ = bookId.Trim();
                    #region Update Book Copies Issued Count
                    // Update Book Issued Count in Book Copies.
                    entity.uspUpdateIssuedCopiesCount(bookId_, branchId);
                    #endregion

                    #region Update Book Loans Table
                    // Update Book Loans Table.
                    bookLoans = new tblBOOK_LOANS();
                    bookLoans = (from item in entity.tblBOOK_LOANS
                                 where item.Book_id == bookId_ && item.Branch_id == branchId
                                 && item.Card_no == cardNumber
                                 select item).FirstOrDefault();
                    bookLoans.Date_in = dateIn;                
                    entity.SaveChanges();
                    #endregion

                    result = true;
                }
                return result;
            }
            catch (Exception e)
            {
                result = false;
                return result;
            }
        }

        /// <summary>
        /// Get Checked out Information for p[articular Book 
        /// </summary>
        /// <param name="bookId">Book Id</param>
        /// <param name="branchId">Branch Id</param>
        /// <param name="borrowerName">Borrower Name</param>
        public List<uspGetBookCheckOutInfo_Result> GetBookCheckOutInfo(string bookId, int cardNumber, string borrowerName)
        {
            List<uspGetBookCheckOutInfo_Result> bookCheckOutInfo;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    bookCheckOutInfo = new List<uspGetBookCheckOutInfo_Result>();
                    bookCheckOutInfo = entity.uspGetBookCheckOutInfo(bookId, cardNumber, borrowerName).ToList();
                    foreach (uspGetBookCheckOutInfo_Result item in bookCheckOutInfo)
                    {
                        if (item.Date_in == null)
                            item.Date_in = DateTime.Now.Date;
                    }
                }
                return bookCheckOutInfo;
            }
            catch (Exception e)
            {
                bookCheckOutInfo = new List<uspGetBookCheckOutInfo_Result>();
                bookCheckOutInfo[0].Fname = "Error :" + e.Message;
                return bookCheckOutInfo;
            }
        }
        #endregion

        #region Add-Update Borrower
        /// <summary>
        /// Check whether borrower with same entry exists in DB
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool IsDuplicateBorrower(string fname, string lname, string address)
        {
            tblBORROWER br;
            bool result = false;
            try
            {
                using(LibraryEntities entity = new LibraryEntities())
                {
                    br = new tblBORROWER();
                    br = (from borrower in entity.tblBORROWERs
                          where borrower.Fname.ToLower() == fname.ToLower() && borrower.Lname.ToLower() == lname.ToLower()
                          && borrower.Address.ToLower() == address.ToLower()
                          select borrower).FirstOrDefault();
                    //If borrower Exists in DB
                    if (br != null)
                        result = true;
                    else
                        result = false;
                }
                return result;
            }
            catch (Exception e)
            {
                result = false;
                return result;                
            }
        }

        /// <summary>
        /// Add the new borrower entry in Database
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public int AddNewBorrwoer(string fname, string lname, string address, string phone,string city,string state)
        {
            tblBORROWER newBorrowerEntry;
            int cardNumber;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    newBorrowerEntry = new tblBORROWER();
                    newBorrowerEntry.Fname = fname.Trim();
                    newBorrowerEntry.Lname = lname.Trim();
                    newBorrowerEntry.Phone = phone.Trim();
                    newBorrowerEntry.Address = address.Trim();
                    newBorrowerEntry.State = state.Trim();
                    newBorrowerEntry.City = city.Trim();
                    entity.AddTotblBORROWERs(newBorrowerEntry);
                    entity.SaveChanges();

                    cardNumber = (from newBorrower in entity.tblBORROWERs
                                  where newBorrower.Fname == fname.Trim() 
                                  && newBorrower.Lname == lname.Trim() && newBorrower.Address == address 
                                  select newBorrower.Card_no).FirstOrDefault();
                }
                return cardNumber;
            }
            catch (Exception e)
            {
                cardNumber = -1;
                return cardNumber;
                // Exception In Entity
            }
        }

        /// <summary>
        /// Update Borrower Information
        /// </summary>
        /// <param name="fname">First Name</param>
        /// <param name="lname">Last Name</param>
        /// <param name="address">Address</param>
        /// <param name="phone">Phone</param>
        /// <param name="newAddress">New Address</param>
        /// <param name="newPhone">New Phone</param>
        /// <returns></returns>
        public bool UpdateBorrower(string fname, string lname, string address, string phone,string newAddress,string newPhone)
        {
            bool result= true;
            tblBORROWER borrowerInfo;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    borrowerInfo = new tblBORROWER();
                    borrowerInfo = (from borrower in entity.tblBORROWERs where borrower.Fname == fname.Trim()
                               && borrower.Lname == lname.Trim() && borrower.Address == address.Trim() select borrower).FirstOrDefault();
                    borrowerInfo.Address = newAddress.Trim();
                    borrowerInfo.Phone = newPhone.Trim();
                    entity.SaveChanges();
                    result = true;
                }
            }
            catch (Exception e)
            {
                result = false;
                return result;
            }
            return result;
        }
        #endregion

        #region Fines
        /// <summary>
        /// Update Fines Table
        /// </summary>
        public void UpdateFines()
        {
            List<int> currentLoanIds;
            tblBOOK_LOANS loans;
            tblFINE fine;
            double overDays = 0;
            double totalFine;
            double finePerDay = 0.25;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    #region Get Loans And Update Fines
                    // Get the all loans of which Fines are Due.
                    #region Fines - Associated with books not returned yet
                    currentLoanIds = new List<int>();
                    currentLoanIds = (from allLoans in entity.tblBOOK_LOANS
                                      where allLoans.Date_in == null && DateTime.Now > allLoans.Due_date
                                      select allLoans.Loan_id).ToList();

                    #endregion

                    //Get All loans which haven't payed Fines
                    #region Fines - Associated with books returned and Not Paid Yet
                    List<int> loanIds = new List<int>();
                    loanIds = (from allLoans in entity.tblBOOK_LOANS
                               join fines in entity.tblFINES on allLoans.Loan_id equals fines.Loan_id 
                               where  allLoans.Date_in > allLoans.Due_date && fines.paid == false
                               select allLoans.Loan_id).ToList();
                    currentLoanIds.AddRange(loanIds);
                    #endregion

                    //update the Fines to above result
                    foreach (int loanid in currentLoanIds)
                    {
                        fine = new tblFINE();
                        loans = new tblBOOK_LOANS();
                        loans = (from loan in entity.tblBOOK_LOANS where loan.Loan_id == loanid select loan).FirstOrDefault();
                        overDays = (DateTime.Now - Convert.ToDateTime(loans.Due_date)).TotalDays;
                        overDays = Math.Floor(overDays);
                        totalFine = overDays * finePerDay;
                        totalFine = Math.Round(totalFine, 2);
                        fine = (from fines in entity.tblFINES
                                where fines.Loan_id == loanid
                                select fines).FirstOrDefault();
                        fine.paid = false;
                        fine.Fine_amount = Convert.ToDecimal(totalFine);
                        entity.SaveChanges();
                    }
                    #endregion

                }
            }
            catch (Exception e)
            {
                // Excetpion in Entity
            }
        }

        /// <summary>
        /// Get the total fine of particular student By Id or Name
        /// </summary>
        /// <param name="cardNumber"></param>
        public List<uspGetFinesById_Result> GetFines(int cardNumber,string borrowerName,bool isReturned)
        {
            List<uspGetFinesById_Result> finesByBook;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    finesByBook = new List<uspGetFinesById_Result>();
                    finesByBook = entity.uspGetFinesById(cardNumber, borrowerName,isReturned).ToList();
                }
                return finesByBook;
            }
            catch (Exception e)
            {
                // exception
                finesByBook = new List<uspGetFinesById_Result>();
                finesByBook[0].Title = e.Message;
                return finesByBook;
            }
        }

        /// <summary>
        /// Fine Payment
        /// </summary>
        /// <param name="finePayment"></param>
        public bool FinePayment(List<uspGetFinesById_Result> finePayment)
        {
            tblFINE fines;
            bool result = true;
            try{
                using (LibraryEntities entity = new LibraryEntities())
                {
                    foreach (uspGetFinesById_Result finesItem in finePayment)
                    {
                        fines = new tblFINE();
                        fines = (from fin in entity.tblFINES
                                 where fin.Book_id == finesItem.Book_id &&
                                 fin.Branch_id == finesItem.Branch_id && fin.Loan_id == finesItem.Loan_id
                                 select fin).FirstOrDefault();
                        fines.paid = true;
                        entity.SaveChanges();

                    }
                    result = true;
                }
                return result;
            }
            catch(Exception e)
            {
                result = false;
                return result;
                // Excetpion in update
            }
        }
        #endregion

        #region Add Update Book Info
        /// <summary>
        /// Add Update Book
        /// </summary>
        /// <param name="bookId">Book Id</param>
        /// <param name="title">Title</param>
        /// <param name="newTitle">New Title</param>
        /// <returns></returns>
        public int AddUpdateBook(string bookId, string title, string newTitle)
        {
            tblBOOK bookInfo;
            int result = 1;
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    bookInfo = new tblBOOK();
                    //Check whether book is already available or not
                    bookInfo = (from bookEntry in entity.tblBOOKs
                                where bookEntry.Book_id == bookId.Trim()
                                    && bookEntry.Title == title.Trim()
                                select bookInfo).FirstOrDefault();

                    // BookInfo is present in database : Update Table
                    if (bookInfo != null && newTitle.Trim() != string.Empty)
                    {
                        bookInfo.Title = newTitle.Trim();
                    }
                    // Add new entry in table
                    else
                    {
                        bookInfo.Book_id = bookId.Trim();
                        bookInfo.Title = title.Trim();
                    }
                    entity.SaveChanges();
                }
                return result;
            }
            catch (Exception e)
            {
                result = -1;
                return result;
            }
        }
        #endregion

    }
}
