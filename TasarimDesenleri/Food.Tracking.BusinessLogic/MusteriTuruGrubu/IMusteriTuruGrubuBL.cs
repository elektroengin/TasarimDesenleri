namespace Food.Tracking.BusinessLogic.MusteriTuruGrubu
{
    public interface IMusteriTuruGrubuBL
    {
        List<Entities.MusteriTuruGrubu> GetMusteriTuruGrubuList();
        Entities.MusteriTuruGrubu GetByMusteriTuruGrubu(Entities.MusteriTuruGrubu entity);
    }
}
