using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Supermarket
{
    public class SampleHealthCheack : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = false;

            // ...

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "An unhealthy result."));
        }


    }
}
