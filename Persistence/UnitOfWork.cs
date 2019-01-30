using System.Threading.Tasks;
using supermasks.Core;
using supermasks.Core.Repositories;
using supermasks.Persistence.Repositories;
using supermasks.Models;

namespace supermasks.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly fantasyfaceContext _context;      

        public UnitOfWork(fantasyfaceContext context)
        {
            _context = context;
            Common = new Common(_context);
            Agents = new AgentsRepository(_context);
            Cats = new CatsRepository(_context);
            Errorlog = new ErrorlogRepository(_context);
            Basket = new BasketRepository(_context);
            CatImages = new CatImagesRepository(_context);
            CatProducts = new CatProductsRepository(_context);
            Colors = new ColorsRepository(_context);
            ColorProducts = new ColorProductsRepository(_context);
            Customers = new CustomersRepository(_context);
            Currencies = new CurrenciesRepository(_context);
            CurrencyDetails = new CurruncyDetailsRepository(_context);
            DeliveryMessage = new DeliveryMessageRepository(_context);
            Genders = new GenderRepository(_context);
            GenderProducts = new GenderProductsRepository(_context);
            ImageProducts = new ImageProductsRepository(_context);
            Pagedetails = new PagedetailsRepository(_context);
            Pages = new PagesRepository(_context);
            Postages = new PostagesRepository(_context);
            Presales = new PresalesRepository(_context);
            Products = new ProductsRepository(_context);
            Promotions = new PromotionsRepository(_context);
            Relatedprods = new RelatedprodsRepository(_context);
            Errorlog = new ErrorlogRepository(_context);
            Reorders = new ReorderRepository(_context);
            Sales = new SalesRepository(_context);
            SalesDetails = new SalesDetailsRepository(_context);
            SalesInfo = new SalesInfoRepository(_context);
            SeoDetails = new SeoDetailsRepository(_context);
            Sizes = new SizesRepository(_context);
            Suppliers = new SuppliersRepository(_context);
            Supplyprods = new SupplyprodsRepository(_context);
            Terms = new TermsRepository(_context);
            Tiers = new TiersRepository(_context);
            Urls = new UrlsRepository(_context);
            Cats = new CatsRepository(_context);
            Sites = new SitesRepository(_context);
            Verifications = new VerificationRepository(_context);
            ConfirmDetails = new ConfirmDetailsRepository(_context);
            EuDetails = new EUDetailsRepository(_context);
            Messages = new MessageRepository(_context);
            RecentProds = new RecentProdsRepository(_context);
        }

        public ICommon Common { get; private set; }
        public IAgentsRepository Agents { get; private set; }
        public IBasketRepository Basket { get; private set; }
        public ICatsRepository Cats { get; private set; }
        public ICatImagesRepository CatImages { get; private set; }
        public ICatProductsRepository CatProducts { get; private set; }
        public IColorsRepository Colors { get; private set; } 
        public IColorProductsRepository ColorProducts { get; private set; } 
        public ICustomersRepository Customers { get; private set; }
        public ICurrenciesRepository Currencies { get; private set; }
        public ICurrencyDetailsRepository CurrencyDetails { get; private set; }
        public IDeliveryMessageRepository DeliveryMessage { get; private set; }
        public IGendersRepository Genders { get; private set; } 
        public IGenderProductsRepository GenderProducts { get; private set; } 
        public IImageProductsRepository ImageProducts { get; private set; }
        public IPagedetailsRepository Pagedetails { get; private set; }
        public IPagesRepository Pages { get; private set; }
        public IPostagesRepository Postages { get; private set; }
        public IPresalesRepository Presales { get; private set; }
        public IProductsRepository Products { get; private set; }
        public IPromotionsRepository Promotions { get; private set; }
        public IRelatedprodsRepository Relatedprods { get; private set; }
        public IErrorlogRepository Errorlog { get; private set; }
        public IReorderRepository Reorders { get; private set; }
        public ISalesRepository Sales { get; private set; }
        public ISalesDetailsRepository SalesDetails { get; private set; }
        public ISalesInfoRepository SalesInfo { get; private set; }
        public ISeoDetailsRepository SeoDetails { get; private set; }
        public ISitesRepository Sites { get; private set; }
        public ISizesRepository Sizes { get; private set; }
        public ISuppliersRepository Suppliers { get; private set; }
        public ISupplyprodsRepository Supplyprods { get; private set; }
        public ITermsRepository Terms { get; private set; }
        public ITiersRepository Tiers { get; private set; }
        public IUrlsRepository Urls { get; private set; }
        public IVerificationsRepository Verifications { get; private set; }
        public IConfirmDetailsRepository ConfirmDetails { get; private set; }
        public IEUDetailsRepository EuDetails { get; private set; }
        public IMessagesRepository Messages { get; private set; }
        public IRecentProdsRepository RecentProds { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}