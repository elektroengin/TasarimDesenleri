using Food.Tracking.DataAccess.Contract.Base;
using Food.Tracking.Entities;

namespace Food.Tracking.DataAccess.Repository
{
    public interface IMusteriTuruGrubuRepository : IBaseRepository<MusteriTuruGrubu>
    {
        /*
           SELECT * FROM [dbo].[Yetki] --GETALL
           SELECT * FROM [dbo].[Yetki] where id = 2 --GETBYID
           INSERT INTO [dbo].[Yetki]([YetkiAdi],[YetkiKey],[Status],[CreatedOn],[CreatedBy],[ModifiedOn] ,[ModifiedBy]) VALUES ('Deneme' , 'Deneme2' , 0, CURRENT_TIMESTAMP,1,null,null) --ADD 
           UPDATE [dbo].[Yetki] set STATUS = 1 WHERE Id = 9 --UPDATE
           DELETE FROM [dbo].[Yetki] WHERE Id = 9 --DELETE
         */
    }
}
