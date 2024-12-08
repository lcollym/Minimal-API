var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

List<string> data = new List<string>
{
    "Provincia Azua\nAzua\nEstebanía\nGuayabal\nLas Charcas\nLas Yayas de Viajama\nPadre Las Casas\nPeralta\nPueblo Viejo\nSabana Yegua\nTábara Arriba\nProvincia Bahoruco\nNeiba\nGalván\nLos Ríos\nTamayo\nVilla Jaragua\nProvincia Barahona\nBarahona\nCabral\nEl Peñón\nEnriquillo\nFundación\nJaquimeyes\nLa Ciénaga\nLas Salinas\nParaíso\nPolo\nVicente Noble\nProvincia Dajabón\nDajabón\nEl Pino\nLoma de Cabrera\nPartido\nRestauración\nProvincia Duarte\nSan Francisco de Macorís\nArenoso\nCastillo\nEugenio María de Hostos\nLas Guáranas\nPimentel\nVilla Riva\nProvincia Elías Piña\nComendador\nBanica\nEl Llano\nHondo Valle\nJuan Santiago\nPedro Santana\nProvincia El Seibo\nEl Seibo\nMiches\nProvincia Espaillat\nMoca\nCayetano Germosén\nGaspar Hernández\nJamao al Norte\nProvincia Hato Mayor\nHato Mayor del Rey\nSabana de la Mar\nEl Valle\nProvincia Hermanas Mirabal\nSalcedo\nTenares\nVilla Tapia\nProvincia Independencia\nJimaní\nCristóbal\nDuvergé\nLa Descubierta\nMella\nPostrer Río\nProvincia La Altagracia\nHigüey\nSan Rafael del Yuma\nProvincia La Romana\nLa Romana\nGuaymate\nVilla Hermosa\nProvincia La Vega\nLa Vega\nConstanza\nJarabacoa\nJima Abajo\nProvincia María Trinidad Sánchez\nNagua\nCabrera\nEl Factor\nRío San Juan\nProvincia Monseñor Nouel\nBonao\nMaimón\nPiedra Blanca\nProvincia Monte Cristi\nMonte Cristi\nCastañuelas\nGuayubín\nLas Matas de Santa Cruz\nPepillo Salcedo\nVilla Vásquez\nProvincia Monte Plata\nMonte Plata\nBayaguana\nSabana Grande de Boyá\nYamasá\nPeralvillo\nProvincia Pedernales\nPedernales\nOviedo\nProvincia Peravia\nBaní\nNizao\nProvincia Puerto Plata\nPuerto Plata\nAltamira\nGuananico\nImbert\nLos Hidalgos\nLuperón\nSosúa\nVilla Isabela\nProvincia Samaná\nSamaná\nLas Terrenas\nSánchez\nProvincia San Cristóbal\nSan Cristóbal\nBajos de Haina\nCambita Garabitos\nLos Cacaos\nNajayo en Medio\nPalenque\nSabana Grande de Palenque\nSan Gregorio de Nigua\nVilla Altagracia\nYaguate\nProvincia San José de Ocoa\nSan José de Ocoa\nSabana Larga\nRancho Arriba\nProvincia San Juan\nSan Juan de la Maguana\nBohechío\nEl Cercado\nJuan de Herrera\nLas Matas de Farfán\nVallejuelo\nProvincia San Pedro de Macorís\nSan Pedro de Macorís\nConsuelo\nGuayacanes\nQuisqueya\nRamón Santana\nProvincia Santiago\nSantiago\nBaitoa\nJánico\nLicey al Medio\nPuñal\nSabana Iglesia\nSan José de Las Matas\nTamboril\nVilla González\nProvincia Santiago Rodríguez\nSan Ignacio de Sabaneta\nLos Almácigos\nMonción\nProvincia Santo Domingo\nSanto Domingo Este\nSanto Domingo Oeste\nSanto Domingo Norte\nBoca Chica\nSan Antonio de Guerra\nPedro Brand\nLos Alcarrizos\nProvincia Valverde\nMao\nEsperanza\nLaguna Salada\nProvincia El Gran Santo Domingo\nBoca Chica\nSanto Domingo Este\nSanto Domingo Oeste\nSanto Domingo Norte\nSan Antonio de Guerra\nLos Alcarrizos\nPedro Brand\n"
};



app.MapGet("/Provincias", () =>
    {
        return data.ToArray();
       
    })
    .WithName("GetProvincias")
    .WithOpenApi();

app.Run();

