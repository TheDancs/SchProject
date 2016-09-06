﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using DbAndRepository;

namespace TechSupportService.DataContract
{
    [DataContract]
    public class TechWork
    {
        [DataMember]
        public WorkerData Technician { get; set; }
        [DataMember]
        public CustomerData Customer { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public DateTime Start { get; set; }
        [DataMember]
        public DateTime Finish { get; set; }

        public static explicit operator TechWork(TechWorks w)
        {
            TechWork work=new TechWork() {Address = w.Customeraddress,Finish = w.Finish,Start = w.Start,Technician =(WorkerData) w.Technician.Worker.LoginData.SingleOrDefault()};
            return work;
        }

    }
}