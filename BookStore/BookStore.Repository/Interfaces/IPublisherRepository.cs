﻿using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{
    public interface IPublisherRepository
    {
        void AddPublisher(Publisher publisher);
        void EditPublisher(Publisher publisher);
        void DeletePublisher(int publisherId);
        Publisher GetPublisherById(int id);
        IEnumerable<Publisher> GetAllPublishers();
    }
}
