using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EsEntity
{
    public class PartialDoctorEntity
    {
        public string DoctorId { get; set; }



        public string SupplierNumber { get; set; }


        public string HospitalId { get; set; }


        public string HospitalNumber { get; set; }
        
        public string HospitalName { get; set; }


        public string HospitalDepartmentId { get; set; }


        public string HospitalDepartmentName { get; set; }


        public string HepartmentNumber { get; set; }


        public string ProfessionalDepartmentId { get; set; }


        public string ProfessionalDepartmentName { get; set; }

        public string DoctorNumber { get; set; }

        public string DoctorName { get; set; }


        public static PartialDoctorEntity Generate(DoctorEntity doctorEntity)
        {
            return new PartialDoctorEntity()
            {
                  SupplierNumber =doctorEntity.SupplierNumber,
                  HospitalId = doctorEntity.HospitalId,
                  HospitalNumber = doctorEntity.HospitalNumber,
                  HospitalName = doctorEntity.HospitalName,
                  HospitalDepartmentId = doctorEntity.HospitalDepartmentId,
                  HospitalDepartmentName = doctorEntity.HospitalDepartmentName,
                  HepartmentNumber = doctorEntity.DepartmentNumber,
                  ProfessionalDepartmentId = doctorEntity.ProfessionalDepartmentId,
                  ProfessionalDepartmentName = doctorEntity.ProfessionalDepartmentName,
                  DoctorNumber = doctorEntity.DoctorNumber,
                  DoctorName = doctorEntity.DoctorName,
            };
        }
    }


}
