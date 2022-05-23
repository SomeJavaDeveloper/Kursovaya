using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Guest
    {
        private int Id;
        private static int IdCounter = 1;
        private string Name;
        private bool IsVipClient;
        private bool IsSeaLandscapeRequired;
        private bool WantToBeAlone;

        public int Id_ { get => Id; set => Id = value; }

        public int IdCounter_ { get => IdCounter; set => IdCounter = value; }
        public string Name_ { get => Name; set => Name = value; }
        public bool IsVipClient_ { get => IsVipClient; set => IsVipClient = value; }
        public bool IsSeaLandscapeRequired_ { get => IsSeaLandscapeRequired; set => IsSeaLandscapeRequired = value; }
        public bool WantToBeAlone_ { get => WantToBeAlone; set => WantToBeAlone = value; }

        public Guest(String name, bool isVipClient, bool isSeaLandscapeRequired, bool wantToBeAlone)
        {
            this.Id = IdCounter;
            ++IdCounter;
            this.Name = name;
            this.IsVipClient = isVipClient;
            this.IsSeaLandscapeRequired = isSeaLandscapeRequired;
            this.WantToBeAlone = wantToBeAlone;
        }

        public Guest(int Id, String name, bool isVipClient, bool isSeaLandscapeRequired, bool wantToBeAlone)
        {
            this.Id = Id;
            this.Name = name;
            this.IsVipClient = isVipClient;
            this.IsSeaLandscapeRequired = isSeaLandscapeRequired;
            this.WantToBeAlone = wantToBeAlone;
        }

        public Guest()
        {
        }

        public override string ToString()
        {
            return "Имя: " + Name + " Id: " + Id;
        }
    }
}
