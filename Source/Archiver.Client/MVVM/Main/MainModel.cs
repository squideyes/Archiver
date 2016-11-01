using Archiver.Client.MVVM.Main;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

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
        [ItemsSource(typeof(ConnStringsItemsSource))]
        public string Storage
        {
            get
            {
                return storage;
            }
            set
            {
                storage = value;

                NotifyPropertyChanged(m => m.Storage);
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

        [Category("Meta-Data")]
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

        [Category("Meta-Data")]
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

        [Category("Meta-Data")]
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

        //[Category("Meta-Data")]
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
