using Agro.Tag.Application.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agro.Tag.Core.Entities;

namespace Agro.Tag.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(typeof(ErrorEtiqueta), 401)]
    public class TagController : ControllerBase
    {
        private readonly ITagAplication _tagApplication;

        public string ErrorEtiqueta { get; private set; }

        public TagController(ITagAplication tagApplication)
        {
            _tagApplication = tagApplication;
        }

        [HttpGet]
        public async Task<IActionResult> GetTags()
        {

            var list = new List<Core.Entities.Tag>();
                
            try
            {
                list = _tagApplication.Get(c => c.Title != "xxx").OrderBy(p => p.Title).ToList();
            }
            catch (Exception ex)
            {
                ErrorEtiqueta err = new ErrorEtiqueta();
                {
                    ErrorEtiqueta = ex.StackTrace;
                };

            }
            return Ok(list);

        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTag(int id)
        {
            Core.Entities.Tag obj=null;

            try
            {
                obj = _tagApplication.Get(id);

                if (obj == null)
                {
                    return NotFound();
                }

               
            }
            catch (Exception ex)
            {
                ErrorEtiqueta err = new ErrorEtiqueta();
                {
                    ErrorEtiqueta = ex.StackTrace;
                };

            }

            return Ok(obj);
        }

        //METER AQUI LOS METODOS NUEVOS QUE TENGO QUE HACER


        //Mi metodo POST
        [HttpPost]

        //Le paso el object Tag

        public IActionResult PostTag([FromBody] Core.Entities.Tag tag)
        {

            Core.Entities.Tag obj = null;

            try
            {
               //obj = _tagApplication.Insert(tag);
               obj= _tagApplication.Insert(tag);

                if (obj == null)
                {
                    return BadRequest();
                }

               
            }
            catch (Exception ex)
            {
                ErrorEtiqueta err = new ErrorEtiqueta();
                {
                    ErrorEtiqueta = ex.StackTrace;
                };

            }
            return Ok(obj);
        }

        //Mi metodo UPDATE

        [HttpPut]

        public IActionResult UpdateTag([FromBody] Core.Entities.Tag tag)
        {

            Core.Entities.Tag obj = null;

            try
            {
                 obj = _tagApplication.Update(tag);

                if (obj == null)
                {
                    return NotFound();
                }

                
            }
            catch (Exception ex)
            {
                ErrorEtiqueta err = new ErrorEtiqueta();
                {
                    ErrorEtiqueta =ex.StackTrace;
                };

            }
            return Ok(obj);

        }

        //Mi metodo DELETE


        [HttpDelete]
        public IActionResult DeleteTag(Core.Entities.Tag tag)
        {

            Core.Entities.Tag obj = null;

            try
            {
                obj = _tagApplication.Deleted(tag);

                if (obj == null)
                {
                    return BadRequest();
                }

                
            }
            catch (Exception ex)
            {
                ErrorEtiqueta err = new ErrorEtiqueta();
                {
                    ErrorEtiqueta = ex.StackTrace;
                };

            }

            return Ok(obj);


        }



    }
 }

