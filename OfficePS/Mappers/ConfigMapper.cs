using AutoMapper;

namespace OfficePS.Mappers
{
    public class ConfigMapper
    {
        public static void RegisterMapper()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ModelToViewMapper>();
                x.AddProfile<ViewToModelMapper>();
            });
        }
    }
}
