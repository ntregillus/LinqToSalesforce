module PluralizationTests

open System
open LinqToSalesforce
open NUnit.Framework
open CodeGeneration
open Translator
open Pluralization

[<Test>]
let ``given table names when I pluralize entity names`` () =
  let testWith (singular:string) (plural:string) =
    let result = pluralize singular
    Assert.AreEqual(plural, result)
  
  testWith "kiss" "kisses"
  testWith "shoe" "shoes"
  testWith "life" "lives"
  testWith "account" "accounts"
  testWith "boy" "boys"
  testWith "foot" "feet"
  testWith "death" "deaths"
  testWith "ActivityHistory" "ActivityHistories"
  testWith "ApexClass" "ApexClasses"
  testWith "Attachment" "Attachments"
  testWith "ContactFeed" "ContactFeeds"
  testWith "LoginIp" "LoginIps"
  testWith "PickCasePriority" "PickCasePriorities"
  testWith "PickCaseProduct" "PickCaseProducts"
  testWith "PickCampaignType" "PickCampaignTypes"
  testWith "PickEventRecurrenceInstance" "PickEventRecurrenceInstances"
  testWith "PickTaskStatus" "PickTaskStatuses"
  

