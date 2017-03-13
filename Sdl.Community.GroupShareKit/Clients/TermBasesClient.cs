﻿using System.Threading.Tasks;
using Sdl.Community.GroupShareKit.Exceptions;
using Sdl.Community.GroupShareKit.Helpers;
using Sdl.Community.GroupShareKit.Http;
using Sdl.Community.GroupShareKit.Models.Response;

namespace Sdl.Community.GroupShareKit.Clients
{
    public class TermBasesClient : ApiClient, ITermBases
    {
        public TermBasesClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        /// <summary>
        /// Gets  <see cref="Termbase"/>s.
        /// </summary>
        /// <remarks>
        /// This method requires authentication.
        /// See the <a href="http://sdldevelopmentpartners.sdlproducts.com/documentation/api">API documentation</a> for more information.
        /// </remarks>
        /// <exception cref="AuthorizationException">
        /// Thrown when the current user does not have permission to make the request.
        /// </exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns> <see cref="Termbase"/></returns>
        public async Task<Termbase> GetTermbases()
        {
            return await ApiConnection.Get<Termbase>(ApiUrls.GetTermbases(), null);
        }
        /// <summary>
        /// Gets  <see cref="TermbaseDetails"/>s.
        /// </summary>
        /// <remarks>
        /// This method requires authentication.
        /// See the <a href="http://sdldevelopmentpartners.sdlproducts.com/documentation/api">API documentation</a> for more information.
        /// </remarks>
        /// <exception cref="AuthorizationException">
        /// Thrown when the current user does not have permission to make the request.
        /// </exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns> <see cref="TermbaseDetails"/></returns>
        public async Task<TermbaseResponse> GetTermbaseById(string termbaseId)
        {
           Ensure.ArgumentNotNullOrEmptyString(termbaseId,"termbaseId");
            return await ApiConnection.Get<TermbaseResponse>(ApiUrls.GetTermbaseById(termbaseId), null);
        }


        /// <summary>
        /// Gets  <see cref="Filter"/>s.
        /// </summary>
        /// <param name="termbaseId"></param>
        /// <remarks>
        /// This method requires authentication.
        /// See the <a href="http://sdldevelopmentpartners.sdlproducts.com/documentation/api">API documentation</a> for more information.
        /// </remarks>
        /// <exception cref="AuthorizationException">
        /// Thrown when the current user does not have permission to make the request.
        /// </exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns> <see cref="Filter"/></returns>
        public async Task<FilterResponse> GetFilters(string termbaseId)
        {
           Ensure.ArgumentNotNullOrEmptyString(termbaseId,"termbaseId");
            return await ApiConnection.Get<FilterResponse>(ApiUrls.GetFilers(termbaseId),null);
        }

        /// <summary>
        /// Serch for a term in a termbase  
        /// </summary>
        /// <param name="request"><see cref="SearchTermRequest"/></param>
        /// <remarks>
        /// This method requires authentication.
        /// See the <a href="http://sdldevelopmentpartners.sdlproducts.com/documentation/api">API documentation</a> for more information.
        /// </remarks>
        /// <exception cref="AuthorizationException">
        /// Thrown when the current user does not have permission to make the request.
        /// </exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns> <see cref="SearchResponse"/></returns>
        public async Task<SearchResponse> SearchTerm(SearchTermRequest request)
        {
            Ensure.ArgumentNotNull(request,"request");
            return await ApiConnection.Get<SearchResponse>(ApiUrls.Search(), request.ToParametersDictionary());
        }
    }
}