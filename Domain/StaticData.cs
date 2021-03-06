﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
	public static class StaticData
	{

		public static void changeCurrentCulture (string currentCulture)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(currentCulture);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentCulture);
		}

		public enum UserTypes
		{
			Client = 1,
			CostAnalyst = 2,
			Manager = 3,
			CostSiteInCharge = 4,
			Finance = 5
		};

		public enum OverallStatus
		{
			PROJECT_PROPOSAL                = 1,
			COST_ANALYST_REVIEW_IN_PROGRESS = 2,
			COST_FUNNEL_IDENTIFIED          = 3,
			FINANCE_REVIEW_IN_PROGRESS      = 4,
			COST_FUNNEL_EVALUATING          = 5,
			INVALID                         = 6,
			//COST_AVOIDANCE                  = 7,
			EXISTING_PROJECT                = 8,
			DUPLICATE_ENTRY                 = 9,
			REALIZATION                     = 10,
			ACTIVE                          = 11,
			COMPLETED                       = 12,
			CANCELED                        = 13,
			//DELAYED							= 14,
			//ON_HOLD							= 15,
			//MONITOR							= 16
		};

		public enum GlobalFunnelStatus
		{
			Identified = 1,
			Evaluating = 2,
			Active = 3,
			Complete = 4,
			Cancelled = 5
		}

		public enum ProjectTypes
		{
			NA = 0,
			COST_SAVINGS   = 1,
			COST_AVOIDANCE = 2,
			ONE_TIME_SAVINGS = 3
		}


		public enum RewardType
		{
			Cash = 1,
			Meal = 2
		}

		public static Dictionary<string, string> GetStatusCounterTreeKeyDesc ()
		{
			var desc = new Dictionary<string, string>();

			desc.Add("NewProposalEntry", DomainResources.NewProductEntry);
			desc.Add("CostFunnelIdentified", DomainResources.CostFunnelIdentified);
			desc.Add("CostFunnelEvaluation", DomainResources.CostFunnelEvaluation);
			desc.Add("Active", DomainResources.ACTIVE);
			desc.Add("Completed", DomainResources.COMPLETED);

			desc.Add("INProgressActionRequired", DomainResources.INProgressActionRequired);

			return desc;
		}

		public static Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, string>>>> GetStatusCounterTree ()
		{
			var tree = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, string>>>>{
				{
					"NewProposalEntry", new Dictionary<string, Dictionary<string, Dictionary<string, string>>>{
						{
							"NA", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.PROJECT_PROPOSAL.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.PROJECT_PROPOSAL).ToString()},
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.PROJECT_PROPOSAL)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						}
					}
				},
				{
					"CostFunnelIdentified", new Dictionary<string, Dictionary<string, Dictionary<string, string>>>{
						{
							"INProgressActionRequired", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.COST_ANALYST_REVIEW_IN_PROGRESS.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.COST_ANALYST_REVIEW_IN_PROGRESS).ToString() },
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.COST_ANALYST_REVIEW_IN_PROGRESS)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								},
								{
									OverallStatus.COST_FUNNEL_IDENTIFIED.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.COST_FUNNEL_IDENTIFIED).ToString() },
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.COST_FUNNEL_IDENTIFIED)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								},
								{
									OverallStatus.FINANCE_REVIEW_IN_PROGRESS.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.FINANCE_REVIEW_IN_PROGRESS).ToString() },
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.FINANCE_REVIEW_IN_PROGRESS)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						},
						//{
						//	"CostAvoidance", new Dictionary<string, Dictionary<string, string>>{
						//		{
						//			OverallStatus.COST_AVOIDANCE.ToString(), new Dictionary<string, string>{
						//				{"status", ((int)OverallStatus.COST_AVOIDANCE).ToString() },
						//				{"counter", "" },
						//				{"statusDesc", GetOverallStatusStr(((int)OverallStatus.COST_AVOIDANCE)) },
						//				{"dollarImpact", "" }
						//			}
						//		}
						//	}
						//},
						{
							"ExistingProject", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.EXISTING_PROJECT.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.EXISTING_PROJECT).ToString() },
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.EXISTING_PROJECT)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						},
						{
							"DoubleEntry", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.DUPLICATE_ENTRY.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.DUPLICATE_ENTRY).ToString() },
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.DUPLICATE_ENTRY)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						},
						{
							"Cancelled", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.CANCELED.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.CANCELED).ToString() },
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.CANCELED)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						},
						{
							"Invalid", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.INVALID.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.INVALID).ToString() },
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.INVALID)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						}
					}
				},
				{
					"CostFunnelEvaluation", new Dictionary<string, Dictionary<string, Dictionary<string, string>>>{
						{
							"NA", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.COST_FUNNEL_EVALUATING.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.COST_FUNNEL_EVALUATING).ToString()},
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.COST_FUNNEL_EVALUATING)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						}
					}
				},
				{
					"Active", new Dictionary<string, Dictionary<string, Dictionary<string, string>>>{
						{
							"NA", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.ACTIVE.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.ACTIVE).ToString()},
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.ACTIVE)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						}
					}
				},
				{
					"Completed", new Dictionary<string, Dictionary<string, Dictionary<string, string>>>{
						{
							"NA", new Dictionary<string, Dictionary<string, string>>{
								{
									OverallStatus.COMPLETED.ToString(), new Dictionary<string, string>{
										{"status", ((int)OverallStatus.COMPLETED).ToString()},
										{"counter", "" },
										{"statusDesc", GetOverallStatusStr(((int)OverallStatus.COMPLETED)) },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						}
					}
				},
				{
					"TotalCount", new Dictionary<string, Dictionary<string, Dictionary<string, string>>>{
						{
							"NA", new Dictionary<string, Dictionary<string, string>>{
								{
									"total", new Dictionary<string, string>{
										{"status", ""},
										{"counter", "" },
										{"statusDesc", "" },
										{"dollarImpact", "" },
										{"actualAmount", "" }
									}
								}
							}
						}
					}
				}
			};

			return tree;
		}


		public static List<int> GetOverallStatusStringList ()
		{
			List<int> status = new List<int>();

			foreach (var sts in Enum.GetValues(typeof(OverallStatus)))
			{
				status.Add(Convert.ToInt32(sts));
			}

			return status;
		}

		public static Dictionary<int, string> GetOverallStatusWithLabel ()
		{
			Dictionary<int, string> status = new Dictionary<int, string>();

			foreach (var sts in Enum.GetValues(typeof(OverallStatus)))
			{
				status.Add(Convert.ToInt32(sts), GetOverallStatusStr(Convert.ToInt32(sts)));
			}

			return status;
		}

		public static string GetRewardTypeStr (int type)
		{
			string typeStr = "Unknown";
			switch (type)
			{
				case (int)RewardType.Cash:
					typeStr = "Cash";
					break;

				case (int)RewardType.Meal:
					typeStr = "Meal";
					break;

				default:
					break;
			}

			return typeStr;
		}

		public static string GetOverallStatusStr (int status)
		{
			string statusStr = DomainResources.NA;
			switch (status)
			{
				case (int)OverallStatus.PROJECT_PROPOSAL:
					statusStr = DomainResources.PROJECT_PROPOSAL;
					break;

				case (int)OverallStatus.COST_ANALYST_REVIEW_IN_PROGRESS:
					statusStr = DomainResources.COST_ANALYST_REVIEW_IN_PROGRESS;
					break;

				case (int)OverallStatus.COST_FUNNEL_IDENTIFIED:
					statusStr = DomainResources.COST_FUNNEL_IDENTIFIED;
					break;

				case (int)OverallStatus.FINANCE_REVIEW_IN_PROGRESS:
					statusStr = DomainResources.FINANCE_REVIEW_IN_PROGRESS;
					break;

				case (int)OverallStatus.COST_FUNNEL_EVALUATING:
					statusStr = DomainResources.COST_FUNNEL_EVALUATING;
					break;

				case (int)OverallStatus.INVALID:
					statusStr = DomainResources.INVALID;
					break;

				case (int)OverallStatus.EXISTING_PROJECT:
					statusStr = DomainResources.EXISTING_PROJECT;
					break;

				case (int)OverallStatus.DUPLICATE_ENTRY:
					statusStr = DomainResources.DUPLICATE_ENTRY;
					break;

				case (int)OverallStatus.REALIZATION:
					statusStr = DomainResources.REALIZATION;
					break;

				case (int)OverallStatus.ACTIVE:
					statusStr = DomainResources.ACTIVE;
					break;

				case (int)OverallStatus.COMPLETED:
					statusStr = DomainResources.COMPLETED;
					break;

				case (int)OverallStatus.CANCELED:
					statusStr = DomainResources.CANCELED;
					break;

				//case (int)OverallStatus.DELAYED:
				//	statusStr = DomainResources.DELAYED;
				//	break;

				//case (int)OverallStatus.ON_HOLD:
				//	statusStr = DomainResources.ON_HOLD;
				//	break;

				//case (int)OverallStatus.MONITOR:
				//	statusStr = DomainResources.MONITOR;
				//	break;

				default:
					break;
			}

			return statusStr;
		}

		/// <summary>
		/// Function that return the equipvalent status of E-Savings and Qlik view (funnel status)
		/// </summary>
		/// <param name="status"></param>
		/// <returns>String status</returns>
		public static string GetSystemStatusMappingToQlikViewStatusStr (int status)
		{
			string statusStr = DomainResources.NA;
			switch (status)
			{
				case (int)OverallStatus.PROJECT_PROPOSAL:
				case (int)OverallStatus.COST_ANALYST_REVIEW_IN_PROGRESS:
				case (int)OverallStatus.COST_FUNNEL_IDENTIFIED:
				case (int)OverallStatus.FINANCE_REVIEW_IN_PROGRESS:
					statusStr = DomainResources.FunnelStatus_identified;// Identified
					break;


				case (int)OverallStatus.COST_FUNNEL_EVALUATING:
					statusStr = DomainResources.FunnelStatus_evaluating; // Evaluating
					break;

				case (int)OverallStatus.INVALID:
				case (int)OverallStatus.EXISTING_PROJECT:
				case (int)OverallStatus.DUPLICATE_ENTRY:
				case (int)OverallStatus.CANCELED:
					statusStr = DomainResources.FunnelStatus_cancelled; // Cancelled
					break;

				case (int)OverallStatus.ACTIVE:
					statusStr = DomainResources.FunnelStatus_active; // Active small
					break;

				case (int)OverallStatus.COMPLETED:
					statusStr = DomainResources.FunnelStatus_complete; // Complete small
					break;


				//case (int)OverallStatus.DELAYED:
				//	statusStr = DomainResources.DELAYED_sm; // Delayed small
				//	break;

				//case (int)OverallStatus.ON_HOLD:
				//	statusStr = DomainResources.ON_HOLD_sm; // on-hold small
				//	break;

				//case (int)OverallStatus.MONITOR:
				//	statusStr = DomainResources.MONITOR_sm; // Monitor small
				//	break;

				default:
					break;
			}

			return statusStr;
		}


		public static List<int> GetGlobalFunnelStatusStringList ()
		{
			List<int> status = new List<int>();

			foreach (var sts in Enum.GetValues(typeof(GlobalFunnelStatus)))
			{
				status.Add(Convert.ToInt32(sts));
			}

			return status;
		}

		public static Dictionary<int, string> GetGlobalFunnelStatusWithLabel ()
		{
			Dictionary<int, string> status = new Dictionary<int, string>();
			status.Add(0, "TBD");

			foreach (var sts in Enum.GetValues(typeof(GlobalFunnelStatus)))
			{
				status.Add(Convert.ToInt32(sts), GetGlobalFunnelStatusStr(Convert.ToInt32(sts)));
			}

			return status;
		}

		public static string GetGlobalFunnelStatusStr (int status)
		{
			string statusStr = "TBD";
			switch (status)
			{
				case (int)GlobalFunnelStatus.Identified:
					statusStr = DomainResources.FunnelStatus_identified;
					break;

				case (int)GlobalFunnelStatus.Evaluating:
					statusStr = DomainResources.FunnelStatus_evaluating;
					break;

				case (int)GlobalFunnelStatus.Active:
					statusStr = DomainResources.FunnelStatus_active;
					break;

				case (int)GlobalFunnelStatus.Complete:
					statusStr = DomainResources.FunnelStatus_complete;
					break;

				case (int)GlobalFunnelStatus.Cancelled:
					statusStr = DomainResources.FunnelStatus_cancelled;
					break;

				default:
					break;
			}

			return statusStr;
		}


		public static string GetUserTypeStr (int userType, bool isMaster)
		{
			string statusStr = "";

			if (userType == (int)UserTypes.Client)
			{
				statusStr = DomainResources.Client;
			}
			else if (userType == (int)UserTypes.Manager)
			{
				statusStr = DomainResources.Manager;
			}
			else if (userType == (int)UserTypes.CostSiteInCharge)
			{
				statusStr = DomainResources.CostSiteInCharge;
			}
			else if (userType == (int)UserTypes.CostAnalyst && isMaster == true)
			{
				statusStr = DomainResources.CostAnalyst +" | "+ DomainResources.MasterAccount;
			}
			else if (userType == (int)UserTypes.CostAnalyst && isMaster == false)
			{
				statusStr = DomainResources.CostAnalyst;
			}
			else if (userType == (int)UserTypes.Finance && isMaster == true)
			{
				statusStr = DomainResources.Finance +" | "+ DomainResources.MasterAccount;
			}
			else if (userType == (int)UserTypes.Finance && isMaster == false)
			{
				statusStr = DomainResources.Finance;
			}
			else
			{
				statusStr = DomainResources.Client;
			}


			return statusStr;
		}


		public static Dictionary<int, string> GetProjectTypeWithLabel ()
		{
			Dictionary<int, string> status = new Dictionary<int, string>();

			foreach (var sts in Enum.GetValues(typeof(ProjectTypes)))
			{
				status.Add(Convert.ToInt32(sts), GetProjectTypeStr(Convert.ToInt32(sts)));
			}

			return status;
		}


		public static List<int> GetProjectTypesStringArray ()
		{
			List<int> types = new List<int>();

			foreach (var type in Enum.GetValues(typeof(ProjectTypes)))
			{
				types.Add(Convert.ToInt32(type));
			}

			return types;
		}


		//public static string GetProjectTypeStr (int type)
		//{
		//	string typeStr = DomainResources.NA;

		//	switch (type)
		//	{
		//		case (int)ProjectTypes.COST_AVOIDANCE:
		//			typeStr = DomainResources.COST_AVOIDANCE;
		//			break;

		//		case (int)ProjectTypes.COST_SAVINGS:
		//			typeStr = DomainResources.COST_SAVINGS;
		//			break;

		//		default:
		//			typeStr = DomainResources.NA;
		//			break;
		//	}

		//	return typeStr;
		//}

		public static string GetProjectTypeStr (int type)
		{
			string typeStr = DomainResources.ForVerification;//"For-Verification";

			switch (type)
			{
				case (int)ProjectTypes.COST_AVOIDANCE:
					typeStr = DomainResources.COST_AVOIDANCE_sm;//"Cost Avoidance";
					break;

				case (int)ProjectTypes.COST_SAVINGS:
					typeStr = DomainResources.COST_SAVINGS_sm; //"Cost Savings";
					break;

				case (int)ProjectTypes.ONE_TIME_SAVINGS:
					typeStr = DomainResources.OneTimeSavings; //"One Time Savings";
					break;

				default:
					typeStr = DomainResources.ForVerification;//"For-Verification";
					break;
			}

			return typeStr;
		}


	}
}
