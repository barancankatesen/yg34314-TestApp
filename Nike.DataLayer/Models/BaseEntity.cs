﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike.DataLayer.Models
{
   public class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate {
            get
            {
                return _addDate;
            }
            set
            {
                _addDate = value;
            }
        }

        private bool _isDeleted = false;
        public bool IsDeleted {
            get
            {
                return _isDeleted;
            }
            set 
            {
                _isDeleted = value;

            }
        }
    }
}
