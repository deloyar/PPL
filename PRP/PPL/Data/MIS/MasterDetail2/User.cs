using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    //[Serializable()]
    //public class User
    //{
    //    [System.Xml.Serialization.XmlElement("name")]
    //    public string Name { get; set; }

    //    [System.Xml.Serialization.XmlElement("age")]
    //    public int Age { get; set; }

    //}


    public class User : NotifyPropertyChanged
    {
        private string id;


        [DataNames("id")]
        public string Id
        {
            get { return id; }
            set { SetField(Id, ref id, value); }
        }

        private string name;

        [DataNames("name")]
        public string Name
        {
            get { return name; }
            set { SetField(Name, ref name, value); }
        }

        private string age;


        [DataNames("age")]
        public string Age
        {
            get { return age; }
            set { SetField(Age, ref age, value); }
        }




    }
}
