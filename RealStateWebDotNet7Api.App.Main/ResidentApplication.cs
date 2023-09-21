using AutoMapper;
using RealStateWebDotNet7Api.App.DTO;
using RealStateWebDotNet7Api.App.Interface;
using RealStateWebDotNet7Api.Domain.Entity;
using RealStateWebDotNet7Api.Domain.Interface;
using RealStateWebDotNet7Api.CrossApp.Common;
using System.Transactions;
using System;
using System.ComponentModel;


namespace RealStateWebDotNet7Api.App.Main
{
    public class ResidentApplication : IResidentApplication
    {
        private readonly IResidentsDomain _residentsDomain;
        private readonly IMapper _mapper;
        private readonly IAppLoger<ResidentApplication> _appLoger;

        private const string errorInsertMessage = ConstantsCustom.MSG_ERROR_INSERT;
        private const string successInsertMessage = ConstantsCustom.MSG_SUCCESS_INSERT;
        private const string successListMessage = ConstantsCustom.MSG_LIST;

        public ResidentApplication(IResidentsDomain residentsDomain, IMapper mapper, IAppLoger<ResidentApplication> appLoger)
        {
            _residentsDomain = residentsDomain;
            _mapper = mapper;
            _appLoger = appLoger;
        }

        #region Sync Methods


        public Response<bool> Insert(ResidentsDTO resident)
        {
            var response = new Response<bool>();
            try
            {
                var mappedresident = _mapper.Map<Residents>(resident);
                response.Data = _residentsDomain.Insert(mappedresident);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = successInsertMessage;
                    _appLoger.LogInformation(LogTypes.Warning.GetEnumDescription(), response.Message);
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                throw;
            }

            return response;
        }


        public Response<bool> Update(ResidentsDTO resident)
        {
            throw new NotImplementedException();
        }

        public Response<bool> Delete(ResidentsDTO resident)
        {
            throw new NotImplementedException();
        }

       

        public Response<ResidentsDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Response<IEnumerable<ResidentsDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Async Methods


        public Response<Task<bool>> InsertAsync(ResidentsDTO resident)
        {
            throw new NotImplementedException();
        }

        public Response<Task<bool>> UpdateAsync(ResidentsDTO resident)
        {
            throw new NotImplementedException();
        }

        public Response<Task<bool>> DeleteAsync(ResidentsDTO resident)
        {
            throw new NotImplementedException();
        }

        public Response<Task<IEnumerable<ResidentsDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Response<Task<ResidentsDTO>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ResponsePag<IEnumerable<ResidentsDTO>> GetAllPaginated(int page, int pageSize)
        {
            var response = new ResponsePag<IEnumerable<ResidentsDTO>>();
            try
            {
                var count = _residentsDomain.CountT();
                var residents = _residentsDomain.GetAllPaginated(page, pageSize);
                response.Data = _mapper.Map<IEnumerable<ResidentsDTO>>(residents);
                if(response.Data != null )
                {
                    response.PageNum = page; 
                    response.TotalPages = (int)Math.Ceiling(count/(double)pageSize);
                    response.TotalRecords = count; 
                    response.IsSuccess = true;
                    response.Message = successListMessage;
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
                response.IsSuccess = false;
               
            }

            return response;
        }

        #endregion



    }
}