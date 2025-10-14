
using Microsoft.EntityFrameworkCore;

namespace MarketSonar.Data;

public class MarketSonarDbContext(DbContextOptions<MarketSonarDbContext> options) : DbContext(options)
{

}