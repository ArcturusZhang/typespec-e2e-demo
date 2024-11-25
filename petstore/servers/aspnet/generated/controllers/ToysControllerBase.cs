// Copyright (c) Microsoft Corporation. All rights reserved.
    // Licensed under the MIT License.
// <auto-generated />

using System;using System.Net;using System.Threading.Tasks;using System.Text.Json;using System.Text.Json.Serialization;using Microsoft.AspNetCore.Mvc;using PetStore.Service.Models;using PetStore.Service;

namespace PetStore.Service.Controllers
{
[ApiController]
public abstract partial class ToysControllerBase: ControllerBase
{

internal abstract IToys ToysImpl { get;}

        ///<summary>
/// Gets an instance of the resource.
///</summary>
        [HttpGet]
        [Route("/pets/{petId}/toys/{toyId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Toy))]
        public virtual async Task<IActionResult> Get(int petId, long toyId)
        {
          var result = await ToysImpl.GetAsync(petId, toyId);
          return Ok(result);
        }

        
        [HttpGet]
        [Route("/pets/{petId}/toys")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ToyCollectionWithNextLink))]
        public virtual async Task<IActionResult> List(int petId, [FromQuery(Name="nameFilter")] string nameFilter)
        {
          var result = await ToysImpl.ListAsync(petId, nameFilter);
          return Ok(result);
        }

}
}