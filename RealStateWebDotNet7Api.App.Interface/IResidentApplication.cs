using RealStateWebDotNet7Api.App.DTO;
using RealStateWebDotNet7Api.CrossApp.Common;

namespace RealStateWebDotNet7Api.App.Interface
{
    public interface IResidentApplication
    {
        #region Sync Methods
        Response<bool> Insert(ResidentsDTO resident);
        Response<bool> Update(ResidentsDTO resident);
        Response<bool> Delete(ResidentsDTO resident);

        Response<ResidentsDTO> Get(int id);
        Response<IEnumerable<ResidentsDTO>> GetAll();
        #endregion

        ResponsePag<IEnumerable<ResidentsDTO>> GetAllPaginated( int page, int pageSize);


        #region Aync Methods
        Response<Task<bool>> InsertAsync(ResidentsDTO resident);
        Response<Task<bool>> UpdateAsync(ResidentsDTO resident);
        Response<Task<bool>> DeleteAsync(ResidentsDTO resident);

        Response<Task<ResidentsDTO>> GetAsync(int id);
        Response<Task<IEnumerable<ResidentsDTO>>> GetAllAsync();
        #endregion

    }
}