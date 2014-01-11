﻿using System;
using KesselRun.HomeLibrary.Model.Enums;

namespace KesselRun.HomeLibrary.Model
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public Publisher Publisher { get; set; }
        public Guid PublisherId { get; set; }
        public BookType TypeOfBook { get; set; }
    }
}