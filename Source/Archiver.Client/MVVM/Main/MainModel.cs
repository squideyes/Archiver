﻿using Archiver.Client.Controls;
using Archiver.Client.MVVM.Main;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;

namespace Archiver.Client
{
    public class MainModel : NotifyBase<MainModel>
    {
        private string storage;
        private string basePath;
        private string project;
        private string owner;
        private string bizUnit;

        [Category("Context")]
        [Required]
        [Description("The Azure Storage Account to upload the archived files to.")]
        [ItemsSource(typeof(AccountItemsSource))]
        public string Account
        {
            get
            {
                return storage;
            }
            set
            {
                storage = value;

                NotifyPropertyChanged(m => m.Account);
            }
        }

        [Category("Context")]
        [Required]
        [DisplayName("Base-Path")]
        [Description("The folder that contains the files and sub-folders you want to archive.")]
        public string BasePath
        {
            get
            {
                return basePath;
            }
            set
            {
                basePath = value;

                NotifyPropertyChanged(m => m.BasePath);
            }
        }

        [Category("Metadata")]
        [Required]
        [Description("The name of the project you want to associate with the uploaded files.")]
        public string Project
        {
            get
            {
                return project;
            }
            set
            {
                project = value;

                NotifyPropertyChanged(m => m.Project);
            }
        }

        [Category("Metadata")]
        [Required]
        [Description("The full-name of the owner of the project.")]
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;

                NotifyPropertyChanged(m => m.Owner);
            }
        }

        [Category("Metadata")]
        [Required]
        [DisplayName("Biz-Unit")]
        [Description("The business unit associated with the project.")]
        public string BizUnit
        {
            get
            {
                return bizUnit;
            }
            set
            {
                bizUnit = value;

                NotifyPropertyChanged(m => m.BizUnit);
            }
        }

        [Category("Metadata")]
        [Required]
        [Editor(typeof(PrimitiveTypeCollectionEditor), typeof(PrimitiveTypeCollectionEditor))]
        [Description("Enter zero or more \"tags\" to associate with the archive.")]
        public List<string> Tags { get; set; } = new List<string>();

        //[Category("Metadata")]
        //[Required]
        //public string Tags { get; set; }

        //[Category("Context")]
        //[Required]
        //public string Retention { get; set; }

        //[Category("Context")]
        //[Required]
        //public string Schedule { get; set; }

        //[Category("Context")]
        //[Required]
        //public string CryptoKey { get; set; }
    }
}
