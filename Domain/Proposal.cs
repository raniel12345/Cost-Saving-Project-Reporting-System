﻿using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using DapperExtensions.Mapper;
using System.Globalization;

namespace Domain
{
	[Table("Proposals")]
	public class Proposal
	{
		private int id;
		[Dapper.Contrib.Extensions.Key]
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}


		private string proposalTicket;

		public string ProposalTicket
		{
			get
			{
				return proposalTicket;
			}
			set
			{
				proposalTicket = value;
			}
		}


		private string projecttitle;

		public string ProjectTitle
		{
			get
			{
				return this.projecttitle;
			}
			set
			{
				this.projecttitle = value;
			}
		}


		private int projectType;

		public int ProjectType
		{
			get
			{
				return projectType;
			}
			set
			{
				projectType = value;
			}
		}



		private string projectTypeIndicator;

		public string ProjectTypeIndicator
		{
			get
			{
				return string.IsNullOrEmpty(projectTypeIndicator) ? StaticData.GetProjectTypeStr(this.ProjectType) : projectTypeIndicator;
			}
			set
			{
				projectTypeIndicator = value;
			}
		}


		private string currentDescription;

		public string CurrentDescription
		{
			get
			{
				return currentDescription;
			}
			set
			{
				currentDescription = value;
			}
		}


		private string proposalDescription;

		public string ProposalDescription
		{
			get
			{
				return proposalDescription;
			}
			set
			{
				proposalDescription = value;
			}
		}

		private string remarks;

		public string Remarks
		{
			get
			{
				return remarks;
			}
			set
			{
				remarks = value;
			}
		}


		private decimal dollarImpact;

		public decimal DollarImpact
		{
			get
			{
				return dollarImpact;
			}
			set
			{
				dollarImpact = value;
			}
		}


		public string DollarImpactFormatted
		{
			get
			{
				return string.Format(new CultureInfo("en-US"), "{0:C}", this.dollarImpact);
			}
		}


		public string ActualAmountFormatted
		{
			get
			{
				return string.Format(new CultureInfo("en-US"), "{0:C}", this.actualAmount);
			}
		}


		public string ProjectedDollarImpact
		{
			get
			{
				decimal projectedDollarImpactTmp = this.DollarImpact * this.NumberOfMonthsToBeActive;
				return string.Format(new CultureInfo("en-US"), "{0:C}", projectedDollarImpactTmp); // projectedDollarImpactTmp.ToString("C");
			}
		}



		private DateTime expectedStartDate = new DateTime(0001, 01, 01);

		public DateTime ExpectedStartDate
		{
			get
			{
				return expectedStartDate;
			}
			set
			{
				expectedStartDate = value;
			}
		}


		private string expectedStartDateStr;

		public string ExpectedStartDateStr
		{
			get
			{
				return string.IsNullOrEmpty(expectedStartDateStr) ? this.ExpectedStartDate.ToString("yyyy-MM-dd") : expectedStartDateStr;
			}
			set
			{
				expectedStartDateStr = value;
			}
		}



		private int oaStatus;

		public int OAStatus
		{
			get
			{
				return oaStatus;
			}
			set
			{
				oaStatus = value;
			}
		}

		private string oaStatusIndicator;

		public string OAStatusIndicator
		{
			get
			{
				return string.IsNullOrEmpty(oaStatusIndicator) ? StaticData.GetOverallStatusStr(this.OAStatus) : oaStatusIndicator;
			}
			set
			{
				oaStatusIndicator = value;
			}
		}


		private string empFFID;

		public string EmpFFID
		{
			get
			{
				return empFFID;
			}
			set
			{
				empFFID = value;
			}
		}



		private string submittedBy;

		public string SubmittedBy
		{
			get
			{
				return submittedBy;
			}
			set
			{
				submittedBy = value;
			}
		}


		private string empDeptCode;

		public string EmpDeptCode
		{
			get
			{
				return empDeptCode;
			}
			set
			{
				empDeptCode = value;
			}
		}

		private string deptName;

		public string DeptName
		{
			get
			{
				return deptName;
			}
			set
			{
				deptName = value;
			}
		}


		private string projectOwnerName;

		public string ProjectOwnerName
		{
			get
			{
				return projectOwnerName;
			}
			set
			{
				projectOwnerName = value;
			}
		}


		private string projectOwnerFFID;

		public string ProjectOwnerFFID
		{
			get
			{
				return projectOwnerFFID;
			}
			set
			{
				projectOwnerFFID = value;
			}
		}


		private string projectOwnerRemarks;

		public string ProjectOwnerRemarks
		{
			get
			{
				return projectOwnerRemarks;
			}
			set
			{
				projectOwnerRemarks = value;
			}
		}


		private string areaDeptBeneficiary;

		public string AreaDeptBeneficiary
		{
			get
			{
				return areaDeptBeneficiary;
			}
			set
			{
				areaDeptBeneficiary = value;
			}
		}



		private int isDeleted = 0;

		public int IsDeleted
		{
			get
			{
				return isDeleted;
			}
			set
			{
				isDeleted = value;
			}
		}


		private DateTime submittedDate = DateTime.UtcNow;

		public DateTime SubmittedDate
		{
			get
			{
				return submittedDate;
			}
			set
			{
				submittedDate = value;
			}
		}

		private int numberOfMonthsToBeActive;

		public int NumberOfMonthsToBeActive
		{
			get
			{
				return numberOfMonthsToBeActive;
			}
			set
			{
				numberOfMonthsToBeActive = value;
			}
		}


		private int isBPI;

		public int IsBPI
		{
			get
			{
				return isBPI;
			}
			set
			{
				isBPI = value;
			}
		}

		private string siteIndicator;

		public string SiteIndicator
		{
			get
			{
				return siteIndicator;
			}
			set
			{
				siteIndicator = value;
			}
		}


		private string siteBaseURL;

		public string SiteBaseURL
		{
			get
			{
				return siteBaseURL;
			}
			set
			{
				siteBaseURL = value;
			}
		}


		private string currentImgsPath;

		public string CurrentImgsPath
		{
			get
			{
				return currentImgsPath;
			}
			set
			{
				currentImgsPath = value;
			}
		}


		private string proposalImgsPath;

		public string ProposalImgsPath
		{
			get
			{
				return proposalImgsPath;
			}
			set
			{
				proposalImgsPath = value;
			}
		}


		private int funnelStatus = 0;

		public int FunnelStatus
		{
			get
			{
				return funnelStatus;
			}
			set
			{
				funnelStatus = value;
			}
		}

		private string funnelStatusIndicator;

		public string FunnelStatusIndicator
		{
			get
			{

				if (FunnelStatus == 0)
				{
					return StaticData.GetSystemStatusMappingToQlikViewStatusStr(this.OAStatus);
				}

				return string.IsNullOrEmpty(funnelStatusIndicator) ? StaticData.GetGlobalFunnelStatusStr(this.FunnelStatus) : funnelStatusIndicator;
			}
			set
			{
				funnelStatusIndicator = value;
			}
		}


		private int financeCategoryID = 1;

		public int FinanceCategoryID
		{
			get
			{
				return financeCategoryID;
			}
			set
			{
				financeCategoryID = value;
			}
		}

		private string financeCategory;

		public string FinanceCategory
		{
			get
			{
				return financeCategory;
			}
			set
			{
				financeCategory = value;
			}
		}


		private int trackingCategoryID = 1;

		public int TrackingCategoryID
		{
			get
			{
				return trackingCategoryID;
			}
			set
			{
				trackingCategoryID = value;
			}
		}

		private string trackingCategory;

		public string TrackingCategory
		{
			get
			{
				return trackingCategory;
			}
			set
			{
				trackingCategory = value;
			}
		}

		private decimal actualAmount;

		public decimal ActualAmount
		{
			get
			{
				return actualAmount;
			}
			set
			{
				actualAmount = value;
			}
		}


		private DateTime originalDueDate;
		//
		// Assign in Submit_Proposal if the user is IDL
		//
		public DateTime OriginalDueDate
		{
			get
			{
				return originalDueDate;
			}
			set
			{
				originalDueDate = value;
			}
		}

		private DateTime currentDueDate;

		public DateTime CurrentDueDate
		{
			get
			{
				return currentDueDate;
			}
			set
			{
				currentDueDate = value;
			}
		}

		private DateTime plannedProjectStartDate;

		public DateTime PlannedProjectStartDate
		{
			get
			{
				return plannedProjectStartDate;
			}
			set
			{
				plannedProjectStartDate = value;
			}
		}


		private DateTime plannedSavingsStartDate;

		public DateTime PlannedSavingsStartDate
		{
			get
			{
				return plannedSavingsStartDate;
			}
			set
			{
				plannedSavingsStartDate = value;
			}
		}


		private DateTime actualCompletionDate;

		public DateTime ActualCompletionDate
		{
			get
			{
				return actualCompletionDate;
			}
			set
			{
				actualCompletionDate = value;
			}
		}



		private IEnumerable<CurrentImg> currentImgs;

		[Computed]
		public IEnumerable<CurrentImg> CurrentImgs
		{
			get
			{
				return currentImgs;
			}
			set
			{
				currentImgs = value;
			}
		}


		private IEnumerable<ProposalImg> proposalImgs;
		[Computed]
		public IEnumerable<ProposalImg> ProposalImgs
		{
			get
			{
				return proposalImgs;
			}
			set
			{
				proposalImgs = value;
			}
		}

		private IEnumerable<SupportingDoc> supportingDocs;
		[Computed]
		public IEnumerable<SupportingDoc> SupportingDocs
		{
			get
			{
				return supportingDocs;
			}
			set
			{
				supportingDocs = value;
			}
		}


		private IList<ProposalCostAnalyst> costAnalysts;

		public IList<ProposalCostAnalyst> CostAnalysts
		{
			get
			{
				return costAnalysts;
			}
			set
			{
				costAnalysts = value;
			}
		}


		private IList<ProposalManagerVerifier> managers;

		public IList<ProposalManagerVerifier> Managers
		{
			get
			{
				return managers;
			}
			set
			{
				managers = value;
			}
		}


		private IList<ProposalAction> neededActions;

		public IList<ProposalAction> NeededActions
		{
			get
			{
				return neededActions;
			}
			set
			{
				neededActions = value;
			}
		}

		private CostSiteInCharge costSiteIncharge;

		public CostSiteInCharge CostSiteInCharge
		{
			get
			{
				return costSiteIncharge;
			}
			set
			{
				costSiteIncharge = value;
			}
		}


		private List<ProposalFinanceApproval> financeApproval;

		public List<ProposalFinanceApproval> FinanceApproval
		{
			get
			{
				return financeApproval;
			}
			set
			{
				financeApproval = value;
			}
		}


	}


	public class ProposalMapper : ClassMapper<Proposal>
	{
		public ProposalMapper ()
		{
			Table("Proposals");
			Map(p => p.ProjectTypeIndicator).Ignore();
			Map(p => p.CurrentImgs).Ignore();
			Map(p => p.SupportingDocs).Ignore();
			Map(p => p.ProposalImgs).Ignore();
			Map(p => p.OAStatusIndicator).Ignore();
			Map(p => p.CostAnalysts).Ignore();
			Map(p => p.Managers).Ignore();
			Map(p => p.NeededActions).Ignore();
			Map(p => p.CostSiteInCharge).Ignore();
			Map(p => p.DeptName).Ignore();
			Map(p => p.FinanceApproval).Ignore();
			Map(p => p.ExpectedStartDateStr).Ignore();
			Map(p => p.SiteIndicator).Ignore();
			Map(p => p.SiteBaseURL).Ignore();
			Map(p => p.CurrentImgsPath).Ignore();
			Map(p => p.ProposalImgsPath).Ignore();
			Map(p => p.ProjectedDollarImpact).Ignore();
			Map(p => p.FinanceCategory).Ignore();
			Map(p => p.TrackingCategory).Ignore();
			Map(p => p.FunnelStatusIndicator).Ignore();
			Map(p => p.DollarImpactFormatted).Ignore();
			Map(p => p.ActualAmountFormatted).Ignore();
			AutoMap();
		}
	}
}
