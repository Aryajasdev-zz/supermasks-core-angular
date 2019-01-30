using System;
using System.Threading.Tasks;
using supermasks.Core.Repositories;

namespace supermasks.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICommon Common { get;}
        IAgentsRepository Agents { get;} 
        IBasketRepository Basket { get;}
        ICatsRepository Cats { get;}
        ICatImagesRepository CatImages { get;}
        ICatProductsRepository CatProducts { get;}
        IColorsRepository Colors { get;}
        IColorProductsRepository ColorProducts { get;} 
        IConfirmDetailsRepository ConfirmDetails { get; }
        ICustomersRepository Customers { get;} 
        ICurrenciesRepository Currencies { get; }
        ICurrencyDetailsRepository CurrencyDetails { get; }
        IDeliveryMessageRepository DeliveryMessage { get;}
        IGendersRepository Genders { get;} 
        IGenderProductsRepository GenderProducts { get;} 
        IImageProductsRepository ImageProducts { get;}
        IPagedetailsRepository Pagedetails { get;}
        IPagesRepository Pages { get;}
        IPostagesRepository Postages { get;}
        IPresalesRepository Presales { get;}
        IProductsRepository Products { get;}
        IPromotionsRepository Promotions { get; }
        IRelatedprodsRepository Relatedprods { get;}
        IErrorlogRepository Errorlog { get;}
        IReorderRepository Reorders { get;}
        ISalesRepository Sales { get;}
        ISalesDetailsRepository SalesDetails { get;}
        ISalesInfoRepository SalesInfo { get;}
        ISeoDetailsRepository SeoDetails { get;}
        ISitesRepository Sites { get;}
        ISizesRepository Sizes { get;}
        ISuppliersRepository Suppliers { get;}
        ISupplyprodsRepository Supplyprods { get;}
        ITermsRepository Terms { get;}
        ITiersRepository Tiers { get;}
        IUrlsRepository Urls { get;}
        IEUDetailsRepository EuDetails { get; }
        IVerificationsRepository Verifications { get; }
        IMessagesRepository Messages { get; }
        IRecentProdsRepository RecentProds { get; }
        int Complete();
        Task CompleteAsync();
    }
}