using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary
{
    class TagModel
    {
      /// <summary>
      /// TODO
      /// Make sure how to use readrate 
      /// </summary>
        public string Name { get; set; }
        public int ReadRate { get; set; }
        public TagModel(string Name,int ReadRate ) {

            this.Name = Name;
            this.ReadRate = ReadRate;


        }

    }
}
