﻿using AlarmBot.Models;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmBot.TopicViews
{
    public class ShowAlarmsTopicView : TemplateRendererMiddleware
    {
        public ShowAlarmsTopicView() : base( new DictionaryRenderer(ReplyTemplates))
        {

        }

        // Template Ids
        public const string SHOWALARMS = "ShowAlarmsTopic.ShowAlarms";

        /// <summary>
        /// Language dictionary of template functions
        /// </summary>
        public static TemplateDictionary ReplyTemplates = new TemplateDictionary
        {
            ["default"] = new TemplateIdMap
                {
                    { SHOWALARMS, (context, data) =>
                        {
                            IEnumerable<Alarm> alarms = (IEnumerable<Alarm>)data;
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("# Current Alarms\n");
                            if (alarms.Any())
                            {
                                foreach(var alarm in alarms)
                                {
                                    sb.AppendLine($"* Title: {alarm.Title} Time: {alarm.Time.Value.ToString("f")}");
                                }
                            }
                            else
                                sb.AppendLine("*There are no alarms defined.*");
                            return sb.ToString();
                        }
                    }
                }
        };


    }
}
