using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH_HANGHOA.entities
{
    public class entities
    {
        private long id;
        private string Ten_san_pham;
        private int So_thung;
        private int So_luong_trong_mot_thung;
        private int So_lon_da_xuat;
        entities(long id, string Ten_san_pham, int So_thung, int So_luong_trong_mot_thung, int So_lon_da_xuat)
        {
            this.id = id;
            this.Ten_san_pham = Ten_san_pham;
            this.So_thung = So_thung;
            this.So_lon_da_xuat = So_lon_da_xuat;
            this.So_luong_trong_mot_thung = So_luong_trong_mot_thung;
        }
    }
}
