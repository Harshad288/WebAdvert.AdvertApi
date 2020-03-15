﻿using AdvertApi.Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace AdvertApi.Controllers.HealthChecks
{
    public class StorageHealthChecks : IHealthCheck
    {
        private readonly IAdvertStorageService _storageService;

        public StorageHealthChecks(IAdvertStorageService storageService)
        {
            _storageService = storageService;
        }


        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var isStorageOk = await _storageService.CheckHealthAsync();
            return new HealthCheckResult(isStorageOk ? HealthStatus.Healthy : HealthStatus.Unhealthy);
        }
    }
}