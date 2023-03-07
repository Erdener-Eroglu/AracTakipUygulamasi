using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakipUygulamasi
{
    public class Arac
    {
        private string _marka;
        private string _model;
        public string Marka
        {
            get => char.ToUpper(_marka[0]) + _marka.Substring(1);
            set
            {
                if (value.Length <= 0)
                    throw new Exception("Bu alanı boş geçemezsin");
                _marka = value;
            }
        }
        public string Model
        {
            get => char.ToUpper(_model[0]) + _model.Substring(1);
            set
            {
                if (value.Length <= 0)
                    throw new Exception("Bu alanı boş geçemezsin");
                _model = value;
            }
        }
        public string SaseNo { get; set; }
        public string YakitTipi { get; set; }
        public string VitesTipi { get; set; }
        public string MotorHacmi { get; set; }

        public string ModelYili { get; set; }
        public byte[] Fotograf { get; set; }

        public override string ToString()
        {
            return $"{Marka} - {Model}";
        }
    }
}
