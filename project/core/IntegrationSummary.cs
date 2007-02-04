using ThoughtWorks.CruiseControl.Remote;

namespace ThoughtWorks.CruiseControl.Core
{
	public class IntegrationSummary
	{
		private IntegrationStatus status;
		private string label;

		public IntegrationSummary(IntegrationStatus status, string label)
		{
			this.status = status;
			this.label = label;
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (obj.GetType() != GetType()) return false;

			IntegrationSummary other = (IntegrationSummary) obj;
			return other.status.Equals(status) && other.label == label;
		}

		public override int GetHashCode()
		{
			return label.GetHashCode();
		}

		public string Label
		{
			get { return label; }
		}

		public IntegrationStatus Status
		{
			get { return status; }
		}
	}
}