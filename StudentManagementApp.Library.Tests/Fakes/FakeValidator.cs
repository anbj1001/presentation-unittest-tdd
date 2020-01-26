﻿using StudentManagementApp.Library.Interfaces;

namespace StudentManagementApp.Library.Tests.Fakes
{
    public class FakeValidator : IStudentValidator
    {
        public bool IsApproved;

        public bool IsApprovedForCSN()
        {
            return IsApproved;
        }
    }
}