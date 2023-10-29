var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //indica al servidor que utilizaremos la arquitectura MVC
var app = builder.Build();

//configuracion para utilizar rutas, archivos estatico y autentificación
app.UseStaticFiles();//va a la carpeta wwwroot para ir a buscar los archivos 
app.UseRouting(); //para usar las rutas
app.UseAuthorization();

app.MapControllerRoute(
    name:"default",
    pattern : "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
