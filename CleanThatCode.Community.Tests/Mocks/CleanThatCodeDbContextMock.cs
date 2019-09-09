using System;
using System.Collections.Generic;
using CleanThatCode.Community.Models.Entities;

namespace CleanThatCode.Community.Tests.Mocks
{
    public static class CleanThatCodeDbContextMock 
    {
        public static IEnumerable<Comment> Comments
        {
            get
            {
                return new List<Comment>
                {
                    new Comment
                    {
                        Id = 1,
                        PostId = 1,
                        Author = "Mum-Ra",
                        Message = "I will eventually get you Lion-O! Just you wait.... Just you wait!",
                        Created = DateTime.Parse("08/12/2016 10:00:07")
                    },
                    new Comment
                    {
                        Id = 2,
                        PostId = 1,
                        Author = "Lion-O",
                        Message = "Mum-Ra! You have been trying for years without success. I am not scared of you!",
                        Created = DateTime.Parse("08/14/2016 13:22:15")
                    }
                };
            }
        }
    }
}