using Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{

}
