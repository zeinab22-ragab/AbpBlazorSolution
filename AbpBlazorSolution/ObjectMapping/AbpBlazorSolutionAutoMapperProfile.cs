using AbpBlazorSolution.Entities;
using AbpBlazorSolution.Services.Dtos.Activity;
using AbpBlazorSolution.Services.Dtos.Category;
using AbpBlazorSolution.Services.Dtos.CompetitionSupplier;
using AbpBlazorSolution.Services.Dtos.Customer;
using AbpBlazorSolution.Services.Dtos.Employee;
using AbpBlazorSolution.Services.Dtos.Invoice;
using AbpBlazorSolution.Services.Dtos.Product;
using AbpBlazorSolution.Services.Dtos.ProductType;
using AbpBlazorSolution.Services.Dtos.ProductUnit;
using AbpBlazorSolution.Services.Dtos.Status;
using AbpBlazorSolution.Services.Dtos.SubTerm;
using AbpBlazorSolution.Services.Dtos.Supplier;
using AbpBlazorSolution.Services.Dtos.Term;
using AbpBlazorSolution.Services.Dtos.Winner;
using AutoMapper;

namespace AbpBlazorSolution.ObjectMapping;

public class AbpBlazorSolutionAutoMapperProfile : Profile
{
    public AbpBlazorSolutionAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */


        //CreateMap<Activity, ActivityDto>();
        //CreateMap<CreateUpdateActivirtDto, Activity>();

        //CreateMap<Category, CategoryDto>();
        //CreateMap<CreateUpdateCategoryDto, Category>();

        
        //CreateMap<CompetitionSupplier, CompetitionSupplierDto>();
        //CreateMap<CreateUpdateCompetitionSupplierDto, CompetitionSupplier>();

       
        //CreateMap<Customer, CustomerDto>();
        //CreateMap<CreateUpdateCustomerDto, Customer>();

       
        //CreateMap<Employee, EmployeesDto>();
        //CreateMap<CreateUpdateEmployeeDto, Employee>();

        
        //CreateMap<Invoice, InvoicesDto>();
        //CreateMap<CreateUpdateInvoiceDto, Invoice>();

     
        //CreateMap<Product, ProductDto>();
        //CreateMap<CreateUpdateProductDto, Product>();

        
        //CreateMap<ProductType, ProductTypeDto>();
        //CreateMap<CreateUpdateProductTypeDto, ProductType>();

        //CreateMap<ProductUnit, ProductUnitDto>();
        //CreateMap<CreateUpdateProductUnitDto, ProductUnit>();

        //CreateMap<Status, StatusDto>();
        //CreateMap<CreateUpdateStatusDto, Status>();

       
        //CreateMap<SubTerm, SubTermDto>();
        //CreateMap<CreateUpdateSubTermDto, SubTerm>();

        
        //CreateMap<Supplier, SupplierDto>();
        //CreateMap<CreateUpdateSupplierDto, Supplier>();

      
        //CreateMap<Term, TermDto>();
        //CreateMap<CreateUpdateTermDto, Term>();

        
        //CreateMap<Winner, WinnerDto>();
        //CreateMap<CreateUpdateWinnerDto, Winner>();
    }
}
