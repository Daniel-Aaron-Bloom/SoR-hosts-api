// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SiteOfRefuge.API.Models;

namespace SiteOfRefuge.API
{
    public class HostsApi
    {
        private ILogger<HostsApi> _logger;

        /// <summary> Initializes a new instance of HostsApi. </summary>
        /// <param name="logger"> Class logger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logger"/> is null. </exception>
        public HostsApi(ILogger<HostsApi> logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            _logger = logger;
        }

        /// <summary> Get a summary list of hosts registered in the system. </summary>
        /// <param name="req"> Raw HTTP Request. </param>
        /// <param name="cancellationToken"> The cancellation token provided on Function shutdown. </param>
        [FunctionName("GetHostsAsync_get")]
        public async Task<IActionResult> GetHostsAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hosts")] HttpRequest req, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("HTTP trigger function processed a request.");

            // TODO: Handle Documented Responses.
            // Spec Defines: HTTP 200

            throw new NotImplementedException();
        }

        /// <summary> Registers a new host in the system. </summary>
        /// <param name="body"> The Host to use. </param>
        /// <param name="req"> Raw HTTP Request. </param>
        /// <param name="cancellationToken"> The cancellation token provided on Function shutdown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        [FunctionName("AddHostAsync_post")]
        public async Task<IActionResult> AddHostAsync([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "hosts")] Host body, HttpRequest req, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("HTTP trigger function processed a request.");

            // TODO: Handle Documented Responses.
            // Spec Defines: HTTP 201

            throw new NotImplementedException();
        }

        /// <summary> Get information about a specific host. </summary>
        /// <param name="req"> Raw HTTP Request. </param>
        /// <param name="id"> Host id in UUID/GUID format. </param>
        /// <param name="cancellationToken"> The cancellation token provided on Function shutdown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        [FunctionName("GetHostAsync_get")]
        public async Task<IActionResult> GetHostAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hosts/{id}")] HttpRequest req, string id, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("HTTP trigger function processed a request.");

            // TODO: Handle Documented Responses.
            // Spec Defines: HTTP 200
            // Spec Defines: HTTP 404

            throw new NotImplementedException();
        }
    }
}
