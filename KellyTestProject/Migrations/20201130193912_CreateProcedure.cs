using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KellyTestProject.Migrations
{
    public partial class CreateProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE [dbo].[GetTopThreeSections]	
                                    AS
	
                                     select top 3 s.Id, s.name from 
	                                    (select v.SectionId, count(id) as cnt 
	                                    from Visits v 
	                                    group by v.SectionId ) t 
	                                    left join Sections s on s.Id = t.SectionId
                                    order by t.cnt desc

                                    RETURN
                                    ");

            migrationBuilder.Sql(@"CREATE PROCEDURE [dbo].[GetTopTenUsers]	
                                    AS
                                    WITH UserStatistic(UserID, SectionId, cnt) as 
                                    (
	                                    select 
			                                    v.UserId, 
			                                    v.SectionId, 
			                                    count(v.id) as cnt 
	                                    from Visits v 
	                                    group by v.UserId, v.SectionId
                                    )
                                    select 
	                                       u.Surname,
	                                       u.Name,
	                                       u.Patronymic,	  
	                                       s.Name as Section
                                    from (
	                                    select top 10 su.UserId
	                                    from UserStatistic su 
                                    group by su.UserId
                                    order by sum(su.cnt) desc) rsu
                                    left join (select sst.UserId, 
				                                      sst.SectionId 
		                                       from (select 
						                                    ss.UserId, 
						                                    ss.SectionId, 
						                                    ROW_NUMBER() over (partition by ss.UserId order by ss.cnt desc) as numSection  
				                                    from UserStatistic ss ) sst where sst.numSection = 1) rss on rss.UserId = rsu.UserID
                                    left join Users u on u.Id = rsu.UserID
                                    left join Sections s on s.Id = rss.SectionId
                                    RETURN");
        }
    }
}
