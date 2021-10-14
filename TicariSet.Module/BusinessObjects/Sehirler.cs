﻿using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TicariSet.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("Ad")]
  
    public class Sehirler : XPObject
    { 
        public Sehirler(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string ad;
        private double lat;
        private double lng;
        private double northeastLat;
        private double northeastLng;
        private double southwestLat;
        private double southwestLng;

        [Size(64)]
        public string Ad
        {
            get => ad;
            set => SetPropertyValue(nameof(Ad), ref ad, value);
        }
        [DbType("decimal(20, 8)")]
        [XafDisplayName("Enlem")]
        public double Lat
        {
            get => lat;
            set => SetPropertyValue(nameof(Lat), ref lat, value);
        }

        [DbType("decimal(20, 8)")]
        [XafDisplayName("Boylam")]
        public double Lng
        {
            get => lng;
            set => SetPropertyValue(nameof(Lng), ref lng, value);
        }
        [DbType("decimal(20, 8)")]
        public double NortheastLat
        {
            get => northeastLat;
            set => SetPropertyValue(nameof(NortheastLat), ref northeastLat, value);
        }
        [DbType("decimal(20, 8)")]
        public double NortheastLng
        {
            get => northeastLng;
            set => SetPropertyValue(nameof(NortheastLng), ref northeastLng, value);
        }
        [DbType("decimal(20, 8)")]
        public double SouthwestLat
        {
            get => southwestLat;
            set => SetPropertyValue(nameof(SouthwestLat), ref southwestLat, value);
        }
        [DbType("decimal(20, 8)")]
        public double SouthwestLng
        {
            get => southwestLat;
            set => SetPropertyValue(nameof(SouthwestLng), ref southwestLng, value);
        }
        [Association("Sehirler-Ilceler")]
        public XPCollection<Ilceler> Ilceler => GetCollection<Ilceler>(nameof(Ilceler));

        [Association("Sehirler-Cari")] 
        public XPCollection<Cariler> Cariler => GetCollection<Cariler>(nameof(Cariler));
    }
}