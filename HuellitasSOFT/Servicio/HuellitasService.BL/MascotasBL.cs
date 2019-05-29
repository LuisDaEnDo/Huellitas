using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Huellitas.DTO.Mascotas;
using HuellitasService.Common.Interfaces;
using HuellitasService.Common.Resources;
using HuellitasService.DAO;

namespace HuellitasService.BL
{
    public class MascotasBL : IMascotaBL
    {
        public MascotaDTO GuardarMascota(MascotaDTO mascota)
        {
            try
            {
                mascota = new MascotasDAO().CrearMascota(mascota);
                mascota.Estado = Status.Success;
            }
            catch (Exception e)
            {
                mascota.Estado = Status.Error;
                mascota.Msg = MensajesError.ErrorGeneral;
            }
            return mascota;
        }

        public List<MascotaDTO> ListarMascotas()
        {
            List<MascotaDTO> mascotas = new List<MascotaDTO>();
            try
            {
                mascotas = new MascotasDAO().ReadMascotas();
            }
            catch (Exception e)
            {
                 
            }
            return mascotas;
            
        }

        public MascotaDTO ActualizarMascota(MascotaDTO mascota)
        {
            try
            {
                mascota = new MascotasDAO().UpdateMascota(mascota);
                mascota.Estado = Status.Success;
            }
            catch (Exception e)
            {
                mascota.Estado = Status.Error;
                mascota.Msg = MensajesError.ErrorGeneral;
            }
            return mascota;
        }

        public MascotaDTO EliminarMascota(MascotaDTO mascota)
        {
            try
            {
                mascota = new MascotasDAO().DeleteMascota(mascota);
                mascota.Estado = Status.Success;
            }
            catch (Exception e)
            {
                mascota.Estado = Status.Error;
                mascota.Msg = MensajesError.ErrorGeneral;
            }
            return mascota;
        }
    }
}
