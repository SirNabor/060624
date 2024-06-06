using education.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using education.API.Data;
using education.Shared.Entities;



namespace education.API.Controllers

{

    [ApiController]

    [Route("/api/Assessments")]

    public class AssessmentsController : ControllerBase

    {

        private readonly DataContext _context;



        public AssessmentsController(DataContext context)

        {

            _context = context;

        }



        //Get con lista 

        //Select * From Assessments 



        [HttpGet]

        public async Task<ActionResult> Get()

        {



            return Ok(await _context.Assessments.ToListAsync());





        }



        // Get por parámetro 

        [HttpGet("{id:int}")]

        public async Task<ActionResult> Get(int id)

        {



            //200 Ok 



            var Assessment = await _context.Assessments.FirstOrDefaultAsync(x => x.Id == id);



            if (Assessment == null)

            {





                return NotFound();

            }



            return Ok(Assessment);





        }





        [HttpPost]

        public async Task<ActionResult> Post(Evaluacion Assessment)

        {

            _context.Add(Assessment);

            await _context.SaveChangesAsync();

            return Ok(Assessment);

        }
    }
}

 