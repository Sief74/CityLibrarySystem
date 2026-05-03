using ConsoleTheme;
using ProjectOOP.Extentions;
using ProjectOOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP.Services
{
    public class LibraryService
    {
        private readonly LibraryBranch _branch;
        private readonly DisplayService _displayService;

        public LibraryService(LibraryBranch branch, DisplayService displayService)
        {
            _branch = branch;
            _displayService = displayService;
        }


        // Handle Borrow 
        public void HandleBorrow()
        {
            string memberId = ThemeHelper.Prompt("Member Id").NormalizeID();
            Member member = _branch.FindMember(memberId);

            _displayService.ShowAvailabeCopies(_branch);

            string copyId = ThemeHelper.Prompt("Copy Id To Borrow : ").NormalizeID();
           BookCopy bookCopy = _branch.FindCopy(copyId);

            bookCopy.Borrow(member);
            _displayService.ShowBorrowSuccess(bookCopy, member);
        }

        // Handle Return 
        public void HandleReturn()
        {
            string copyId = ThemeHelper.Prompt("Copy Id To Return ").NormalizeID();
            BookCopy copy = _branch.FindCopy(copyId);

            decimal fine = copy.Return();
            _displayService.ShowReturnSuccess(copy , fine);
        }

        // Handle History
        public void HandleHistory()
        {
            string memberId = ThemeHelper.Prompt("Member Id ");
            Member member = _branch.FindMember(memberId);
            _displayService.ShowMemberHistory(member);
        }

        // Handle Register Member 
        public void HandleRegisterMember()
        {
            string name = ThemeHelper.Prompt("Full Name");

            string phone = ThemeHelper.Prompt("Phone Number");
            if (!phone.ContainsDigit())
                throw new InvalidOperationException("Phone Number is Not Valid");

            string email = ThemeHelper.Prompt("Email ");
            if (!email.IsValidEmail())
                throw new InvalidOperationException("Email is Not Valid");

            Member member  = _branch.RegisterMember(name, null, email, phone, DateOnly.FromDateTime(DateTime.Today));

            _displayService.ShowRegisterSuccess(member);
        }

    }
}
