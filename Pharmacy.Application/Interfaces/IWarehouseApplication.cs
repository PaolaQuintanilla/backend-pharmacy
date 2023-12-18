using Pharmacy.Application.Commons.Bases.Request;
using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.Warehouse.Request;
using Pharmacy.Application.Dtos.Warehouse.Response;

namespace Pharmacy.Application.Interfaces
{
    public interface IWarehouseApplication
    {
        Task<BaseResponse<IEnumerable<WarehouseResponseDto>>> ListWarehouses(BaseFiltersRequest filters);
        Task<BaseResponse<WarehouseByIdResponseDto>> WarehouseById(int warehouseId);
        Task<BaseResponse<bool>> RegisterWarehouse(WarehouseRequestDto requestDto);
        Task<BaseResponse<bool>> EditWarehouse(int warehouseId, WarehouseRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveWarehouse(int warehouseId);
    }
}