using ConsoleTheme;
using ProjectOOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP.Services
{
    public class DisplayService
    {
        public void ShowBranchInfo(LibraryBranch branch)
        {
            ThemeHelper.PrintHeader("LIBRARY BRANCH INFO");
            Console.WriteLine(branch.ToDisplayString());
        }

        public void ShowAllUsers(LibraryBranch branch)
        {
            ThemeHelper.PrintHeader("All Registered Users");

            IReadOnlyList<LibraryUser> Users = branch.Users;
            for (int i = 0; i < branch.Users.Count; i++)
            {
                string header = Users[i] is Librarian ? "LIBRARIAN PROFILE" : "MEMBER PROFILE";
                ThemeHelper.PrintSectionTitle(header);
                Console.WriteLine(Users[i].ToDisplayString());
            }
        }

        public void ShowAvailabeCopies(LibraryBranch branch)
        {
            ThemeHelper.PrintHeader("Available Book Copies :");
            List<BookCopy> books = branch.GetAvailableCopies();
            if(books.Count ==0)
            {
                ThemeHelper.PrintWarning("No available book copies found.");
                return;
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine(books[i].ToDisplayString());

                }
            }
        }

        public void ShowAllBookCopies(LibraryBranch branch)
        {
            ThemeHelper.PrintHeader("All Book Copies");
            if(branch.Copies.Count ==0)
            {
                ThemeHelper.PrintWarning("No book copies found ");
                return;
            }
            else
            {
                for (int i = 0; i < branch.Copies.Count; i++)
                {
                    Console.WriteLine(branch.Copies[i].ToDisplayString());
                }
            }
        }

        public void ShowMemberHistory(Member member)
        {
            ThemeHelper.PrintSectionTitle($"Borrowing History For{member.Name}");
            Console.WriteLine(member.GetHistoryDisplayString());
        }

        public void ShowBorrowSuccess(BookCopy copy , Member member)
        {
            ThemeHelper.PrintSuccess($"Copy {copy.CopyId} : {copy.Book.Title} Borrow by {member.Name}");
            ThemeHelper.PrintSuccess($"Due Date {copy.ActiveTransaction!.DueDate:dd/MM/yyyy}");

        }

        public void ShowReturnSuccess(BookCopy bookCopy , decimal fine)
        {
            ThemeHelper.PrintSuccess($"Copy {bookCopy.CopyId} : {bookCopy.Book.Title} Returned ");
            if (fine > 0)
                ThemeHelper.PrintWarning($"Late Returned Fine {fine:f2} EGP");
            else
                ThemeHelper.PrintSuccess($"Returned On Time , No Fine");
        }

        public void ShowRegisterSuccess(Member member)
        {
            ThemeHelper.PrintSuccess($"Member : {member.Name} - {member.MembershipId} Registered");
        }

        public void ShowAddCopySuccess(BookCopy bookCopy)
        {
            ThemeHelper.PrintSuccess($"Member : {bookCopy.CopyId} - {bookCopy.Book.Title} Added");
        }



    }
}
