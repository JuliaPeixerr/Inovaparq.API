using Microsoft.OpenApi.Models;

namespace Incubadora.Swagger
{
    public static class Configurator
    {
        public static IServiceCollection AddSwaggerConfigurator(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.OperationFilter<AddHeaders>();
            });

            return services;
        }

        public class AddHeaders : Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter
        {
            private readonly IWebHostEnvironment _env;

            public AddHeaders(IWebHostEnvironment env)
                => _env = env;

            public void Apply(OpenApiOperation operation,
                Swashbuckle.AspNetCore.SwaggerGen.OperationFilterContext context)
            {
                if (operation.Parameters == null)
                    operation.Parameters = new List<OpenApiParameter>();

                var isDev = _env.IsDevelopment();

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "x-token",
                    In = ParameterLocation.Header,
                    Required = true,
                    Description = "Token de segurança do cliente",
                    Schema = new OpenApiSchema
                    {
                        Type = "string",
                        Default = new Microsoft.OpenApi.Any.OpenApiString(isDev ? "vEpZuVripoZxJEbG1cijlgjEXh64AK0W" : "")
                    }
                });

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "x-user",
                    In = ParameterLocation.Header,
                    Required = true,
                    Description = "Usuário que está fazendo a requisição",
                    Schema = new OpenApiSchema
                    {
                        Type = "string",
                        Default = new Microsoft.OpenApi.Any.OpenApiString(isDev ? "Julia" : "")
                    }
                });
            }
        }
    }
}
