namespace APi.Services.IServices
{
    public interface IAppoinmentProcess
    {

        Task<bool> createAppointment();

        Task<bool> updateAppointment();

        Task<bool> deleteAppointment();

        Task<bool> GetAssignedAppointmentList();

        Task<bool> GetCreatedAppointmentList();
    }
}
