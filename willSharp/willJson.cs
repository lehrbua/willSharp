using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace willSharp
{

    public class willJson
    {
        public Props props { get; set; }
        public string page { get; set; }
        public Query query { get; set; }
        public string buildId { get; set; }
        public Runtimeconfig runtimeConfig { get; set; }
        public bool isFallback { get; set; }
        public bool isExperimentalCompile { get; set; }
        public bool gip { get; set; }
        public bool appGip { get; set; }
        public object[] scriptLoader { get; set; }
    }

    public class Props
    {
        public Pageprops pageProps { get; set; }
        public bool showVerificationAlert { get; set; }
        public string userAgent { get; set; }
        public bool isSSG { get; set; }
        public Toggles toggles { get; set; }
        public Initialoptimizelydatafile initialOptimizelyDatafile { get; set; }
        public Cookies cookies { get; set; }
        public bool is404 { get; set; }
        public Verticalsinfo verticalsInfo { get; set; }
    }

    public class Pageprops
    {
        public Searchresult searchResult { get; set; }
        public Searchterm[] searchTerms { get; set; }
        public Categorysuggestion[] categorySuggestions { get; set; }
        public string defaultViewMode { get; set; }
    }

    public class Searchresult
    {
        public int id { get; set; }
        public string description { get; set; }
        public string heading { get; set; }
        public int verticalId { get; set; }
        public int searchId { get; set; }
        public int rowsRequested { get; set; }
        public int rowsFound { get; set; }
        public int rowsReturned { get; set; }
        public int pageRequested { get; set; }
        public string searchDate { get; set; }
        public object lastUserAlertViewedDate { get; set; }
        public object newAdsSeparatorPosition { get; set; }
        public Advertsummarylist advertSummaryList { get; set; }
        public Breadcrumb[] breadcrumbs { get; set; }
        public Navigatorgroup[] navigatorGroups { get; set; }
        public Searchexcludelist searchExcludeList { get; set; }
        public Paginglinkslist pagingLinksList { get; set; }
        public Sortorderlist sortOrderList { get; set; }
        public Searchcontextlinks searchContextLinks { get; set; }
        public Taggingdata taggingData { get; set; }
        public Seometadata seoMetaData { get; set; }
        public Autocompletelinklist autocompleteLinkList { get; set; }
        public string searchTitle { get; set; }
        public string searchSubTitle { get; set; }
        public Advertisingparameters advertisingParameters { get; set; }
        public Advertisingparametersv2 advertisingParametersV2 { get; set; }
        public Dmpparameters dmpParameters { get; set; }
        public Dmpuseridentities dmpUserIdentities { get; set; }
        public Metadata metaData { get; set; }
        public object statistics { get; set; }
    }

    public class Advertsummarylist
    {
        public Advertsummary[] advertSummary { get; set; }
    }

    public class Advertsummary
    {
        public string id { get; set; }
        public int verticalId { get; set; }
        public int adTypeId { get; set; }
        public int productId { get; set; }
        public Advertstatus advertStatus { get; set; }
        public string description { get; set; }
        public Attributes attributes { get; set; }
        public Advertimagelist advertImageList { get; set; }
        public string selfLink { get; set; }
        public Contextlinklist contextLinkList { get; set; }
        public Advertiserinfo advertiserInfo { get; set; }
        public object upsellingOrganisationLogo { get; set; }
        public object[] teaserAttributes { get; set; }
        public object children { get; set; }
    }

    public class Advertstatus
    {
        public string id { get; set; }
        public string description { get; set; }
        public int statusId { get; set; }
    }

    public class Attributes
    {
        public Attribute[] attribute { get; set; }
    }

    public class Attribute
    {
        public string name { get; set; }
        public object[] values { get; set; }
    }

    public class Advertimagelist
    {
        public Advertimage[] advertImage { get; set; }
        public object[] floorPlans { get; set; }
    }

    public class Advertimage
    {
        public int id { get; set; }
        public string name { get; set; }
        public string selfLink { get; set; }
        public string description { get; set; }
        public string mainImageUrl { get; set; }
        public string thumbnailImageUrl { get; set; }
        public string referenceImageUrl { get; set; }
        public object similarImageSearchUrl { get; set; }
        public string reference { get; set; }
    }

    public class Contextlinklist
    {
        public Contextlink[] contextLink { get; set; }
    }

    public class Contextlink
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Advertiserinfo
    {
        public object label { get; set; }
        public object iconSVG { get; set; }
        public object iconPNG { get; set; }
        public string iconType { get; set; }
    }

    public class Searchexcludelist
    {
        public Contextlink1[] contextLink { get; set; }
    }

    public class Contextlink1
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Paginglinkslist
    {
        public Contextlink2[] contextLink { get; set; }
    }

    public class Contextlink2
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Sortorderlist
    {
        public Contextlink3[] contextLink { get; set; }
    }

    public class Contextlink3
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Searchcontextlinks
    {
        public Contextlink4[] contextLink { get; set; }
    }

    public class Contextlink4
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
        public string iconPNG { get; set; }
        public string iconSVG { get; set; }
    }

    public class Taggingdata
    {
        public Taggingnames taggingNames { get; set; }
        public Tmsdatavalues tmsDataValues { get; set; }
        public Pulsedata pulseData { get; set; }
        public Neustartaggingdata neustarTaggingData { get; set; }
    }

    public class Taggingnames
    {
        public Namevaluepair[] nameValuePair { get; set; }
    }

    public class Namevaluepair
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Tmsdatavalues
    {
        public Tmsdata tmsData { get; set; }
    }

    public class Tmsdata
    {
        public string search_results_number { get; set; }
        public string ad_type { get; set; }
        public string page_type { get; set; }
        public string vertical_id { get; set; }
        public string vertical { get; set; }
        public string category_level_id_1 { get; set; }
        public string source { get; set; }
        public string search_terms { get; set; }
        public string category_level_1 { get; set; }
        public string environment { get; set; }
        public string category_level_max { get; set; }
        public string search_results_displaycount { get; set; }
        public string event_name { get; set; }
        public string search_results_page { get; set; }
    }

    public class Pulsedata
    {
        public Pulseevent[] pulseEvents { get; set; }
    }

    public class Pulseevent
    {
        public string type { get; set; }
        public int id { get; set; }
        public int contentId { get; set; }
        public string name { get; set; }
        public string adType { get; set; }
        public object[] items { get; set; }
        public Classifiedadobject[] classifiedAdObjects { get; set; }
        public int numItems { get; set; }
        public string category { get; set; }
        public Filters filters { get; set; }
        public Search search { get; set; }
    }

    public class Filters
    {
        public string adType { get; set; }
        public string sorting { get; set; }
        public string query { get; set; }
        public string numResults { get; set; }
    }

    public class Search
    {
        public string id { get; set; }
        public string type { get; set; }
        public int maxRank { get; set; }
        public int offset { get; set; }
        public Genericsearchfilter[] genericSearchFilters { get; set; }
        public int searchConfigId { get; set; }
    }

    public class Genericsearchfilter
    {
        public string label { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public string[] values { get; set; }
    }

    public class Classifiedadobject
    {
        public string type { get; set; }
        public int id { get; set; }
        public int adId { get; set; }
        public string adUuid { get; set; }
        public Publisher publisher { get; set; }
    }

    public class Publisher
    {
        public string id { get; set; }
        public string accountId { get; set; }
        public string type { get; set; }
    }

    public class Neustartaggingdata
    {
        public string mainCategory { get; set; }
        public string vertical { get; set; }
        public string device { get; set; }
    }

    public class Seometadata
    {
        public string canonicalUrl { get; set; }
        public string alternateUrl { get; set; }
        public string title { get; set; }
        public string keywords { get; set; }
        public string description { get; set; }
        public object orgId { get; set; }
    }

    public class Autocompletelinklist
    {
        public Contextlink5[] contextLink { get; set; }
    }

    public class Contextlink5
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Advertisingparameters
    {
        public string[] pagetype { get; set; }
        public string[] pricemin { get; set; }
        public string[] pricemax { get; set; }
        public string[] search_alert { get; set; }
        public string[] searchcount { get; set; }
        public string[] payliveryEnabled { get; set; }
        public string[] Zustand { get; set; }
        public string[] vertical { get; set; }
        public string[] keyword { get; set; }
        public string[] device { get; set; }
    }

    public class Advertisingparametersv2
    {
        public string pagetype { get; set; }
        public int pricemin { get; set; }
        public int pricemax { get; set; }
        public string search_alert { get; set; }
        public int searchcount { get; set; }
        public string payliveryEnabled { get; set; }
        public string[] Zustand { get; set; }
        public string vertical { get; set; }
        public string keyword { get; set; }
        public string device { get; set; }
    }

    public class Dmpparameters
    {
        public string pagetype { get; set; }
        public int pricemin { get; set; }
        public int pricemax { get; set; }
        public bool search_alert { get; set; }
        public int searchcount { get; set; }
        public bool payliveryEnabled { get; set; }
        public string[] Zustand { get; set; }
        public string vertical { get; set; }
        public string keyword { get; set; }
        public string device { get; set; }
    }

    public class Dmpuseridentities
    {
    }

    public class Metadata
    {
        public string viewMode { get; set; }
        public int defaultPageSize { get; set; }
    }

    public class Breadcrumb
    {
        public string displayName { get; set; }
        public string seoUrl { get; set; }
    }

    public class Navigatorgroup
    {
        public string label { get; set; }
        public Navigatorlist[] navigatorList { get; set; }
    }

    public class Navigatorlist
    {
        public string id { get; set; }
        public string label { get; set; }
        public object[] possibleValues { get; set; }
        public Groupedpossiblevalue[] groupedPossibleValues { get; set; }
        public Selectedvalue[] selectedValues { get; set; }
        public string navigatorType { get; set; }
        public string navigatorSelectionType { get; set; }
        public Urlconstructioninformation urlConstructionInformation { get; set; }
        public Resetallinformation resetAllInformation { get; set; }
        public string navigatorValuesDisplayType { get; set; }
        public string[] metaTags { get; set; }
        public string[] navigatorValuesDisplayStyle { get; set; }
        public Metadata1 metadata { get; set; }
        public Navigatorfromvalue[] navigatorFromValues { get; set; }
        public Navigatortovalue[] navigatorToValues { get; set; }
        public Quicktoggle quickToggle { get; set; }
        public Defaultfromnavigatorvalue defaultFromNavigatorValue { get; set; }
        public Defaulttonavigatorvalue defaultToNavigatorValue { get; set; }
        public object[] alternativeRanges { get; set; }
        public object alternativeLabel { get; set; }
        public object unit { get; set; }
    }

    public class Urlconstructioninformation
    {
        public Baseurl baseUrl { get; set; }
        public Urlparam[] urlParams { get; set; }
    }

    public class Baseurl
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Urlparam
    {
        public string urlParameterName { get; set; }
        public string navigatorUrlParameterType { get; set; }
    }

    public class Resetallinformation
    {
        public Resetallurl resetAllUrl { get; set; }
    }

    public class Resetallurl
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Metadata1
    {
        public string parameterName { get; set; }
        public string[] treeAttributeXmlNames { get; set; }
    }

    public class Quicktoggle
    {
        public string label { get; set; }
        public bool on { get; set; }
        public Onstate onState { get; set; }
        public Offstate offState { get; set; }
    }

    public class Onstate
    {
        public Fromvalue fromValue { get; set; }
        public Tovalue toValue { get; set; }
    }

    public class Fromvalue
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Tovalue
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Offstate
    {
        public Fromvalue1 fromValue { get; set; }
        public Tovalue1 toValue { get; set; }
    }

    public class Fromvalue1
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Tovalue1
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Defaultfromnavigatorvalue
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Defaulttonavigatorvalue
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Groupedpossiblevalue
    {
        public object label { get; set; }
        public Possiblevalue[] possibleValues { get; set; }
    }

    public class Possiblevalue
    {
        public string label { get; set; }
        public object prePostTextInfo { get; set; }
        public Image[] images { get; set; }
        public Urlparamrepresentationforvalue[] urlParamRepresentationForValue { get; set; }
        public object parent { get; set; }
        public object parentId { get; set; }
        public object parentLabel { get; set; }
        public Searchlink searchLink { get; set; }
        public Weblink webLink { get; set; }
        public int hits { get; set; }
        public object[] metaTags { get; set; }
    }

    public class Searchlink
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Weblink
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Urlparamrepresentationforvalue
    {
        public string urlParameterName { get; set; }
        public string navigatorUrlParameterType { get; set; }
        public string value { get; set; }
    }

    public class Selectedvalue
    {
        public string label { get; set; }
        public object prePostTextInfo { get; set; }
        public object[] images { get; set; }
        public Urlparamrepresentationforvalue1[] urlParamRepresentationForValue { get; set; }
        public object parent { get; set; }
        public object parentId { get; set; }
        public object parentLabel { get; set; }
        public Resetlink resetLink { get; set; }
    }

    public class Resetlink
    {
        public string id { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public bool selected { get; set; }
        public string relativePath { get; set; }
        public string serviceName { get; set; }
    }

    public class Urlparamrepresentationforvalue1
    {
        public string urlParameterName { get; set; }
        public string navigatorUrlParameterType { get; set; }
        public string value { get; set; }
    }

    public class Navigatorfromvalue
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Navigatortovalue
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Searchterm
    {
        public string title { get; set; }
        public Searchterm1[] searchTerms { get; set; }
    }

    public class Searchterm1
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Categorysuggestion
    {
        public string name { get; set; }
        public int id { get; set; }
        public int count { get; set; }
        public int totalCount { get; set; }
    }

    public class Toggles
    {
        public bool enableUserZoomMyProfile { get; set; }
        public bool enableUserZoomAutoMotorResultList { get; set; }
        public bool enableUserZoomAutoMotorAdDetail { get; set; }
        public bool enableUserZoomAutoMotorStartpages { get; set; }
        public bool enableUserZoomRealEstateResultList { get; set; }
        public bool enableUserZoomRealEstateDetailSearch { get; set; }
        public bool enableUserZoomRealEstateStartpage { get; set; }
        public bool enableUserZoomRealEstateAdDetail { get; set; }
        public bool enableUserZoomBapAdDetail { get; set; }
        public bool enableUserZoomBapResultList { get; set; }
        public bool enableUserZoomBapStartPage { get; set; }
        public bool enableUserZoomStartPage { get; set; }
        public bool enableUserZoomAzaNegativePage { get; set; }
        public bool enableUserZoomAzaPositivePage { get; set; }
        public bool enableUserZoomFashion { get; set; }
        public bool enableUserZoomPriceFinder { get; set; }
        public bool enableShippingCampaign { get; set; }
        public bool disableZendeskWidget { get; set; }
        public bool dsaReportingIadEnabled { get; set; }
        public bool dsaReportingMessagingEnabled { get; set; }
        public bool enableBudgetCalculatorInFilterRealEstateResultList { get; set; }
        public bool enableSizePersonalization { get; set; }
        public bool enableAutoMotorDealerProfile { get; set; }
        public bool enableMyTransactionsPage { get; set; }
    }

    public class Initialoptimizelydatafile
    {
        public string accountId { get; set; }
        public string projectId { get; set; }
        public string revision { get; set; }
        public Attribute1[] attributes { get; set; }
        public Audience[] audiences { get; set; }
        public string version { get; set; }
        public Event[] events { get; set; }
        public object[] integrations { get; set; }
        public bool anonymizeIP { get; set; }
        public bool botFiltering { get; set; }
        public object[] typedAudiences { get; set; }
        public object[] variables { get; set; }
        public string environmentKey { get; set; }
        public string sdkKey { get; set; }
        public Featureflag[] featureFlags { get; set; }
        public Rollout[] rollouts { get; set; }
        public object[] experiments { get; set; }
        public object[] groups { get; set; }
    }

    public class Attribute1
    {
        public string id { get; set; }
        public string key { get; set; }
    }

    public class Audience
    {
        public string id { get; set; }
        public string name { get; set; }
        public string conditions { get; set; }
    }

    public class Event
    {
        public string id { get; set; }
        public object[] experimentIds { get; set; }
        public string key { get; set; }
    }

    public class Featureflag
    {
        public string id { get; set; }
        public string key { get; set; }
        public string rolloutId { get; set; }
        public object[] experimentIds { get; set; }
        public Variable[] variables { get; set; }
    }

    public class Variable
    {
        public string id { get; set; }
        public string key { get; set; }
        public string type { get; set; }
        public string defaultValue { get; set; }
    }

    public class Rollout
    {
        public string id { get; set; }
        public Experiment[] experiments { get; set; }
    }

    public class Experiment
    {
        public string id { get; set; }
        public string key { get; set; }
        public string status { get; set; }
        public string layerId { get; set; }
        public Variation[] variations { get; set; }
        public Trafficallocation[] trafficAllocation { get; set; }
        public Forcedvariations forcedVariations { get; set; }
        public object[] audienceIds { get; set; }
        public object[] audienceConditions { get; set; }
    }

    public class Forcedvariations
    {
    }

    public class Variation
    {
        public string id { get; set; }
        public string key { get; set; }
        public bool featureEnabled { get; set; }
        public Variable1[] variables { get; set; }
    }

    public class Variable1
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class Trafficallocation
    {
        public string entityId { get; set; }
        public int endOfRange { get; set; }
    }

    public class Cookies
    {
    }

    public class Verticalsinfo
    {
        public Vertical[] vertical { get; set; }
    }

    public class Vertical
    {
        public int id { get; set; }
        public string description { get; set; }
        public int nrOfAdverts { get; set; }
        public string selfLink { get; set; }
        public string searchConfigLink { get; set; }
        public string startPageLink { get; set; }
        public Taggingdata1 taggingData { get; set; }
    }

    public class Taggingdata1
    {
        public Taggingnames1 taggingNames { get; set; }
        public Tmsdatavalues1 tmsDataValues { get; set; }
        public object pulseData { get; set; }
        public object neustarTaggingData { get; set; }
    }

    public class Taggingnames1
    {
        public Namevaluepair1[] nameValuePair { get; set; }
    }

    public class Namevaluepair1
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Tmsdatavalues1
    {
        public Tmsdata1 tmsData { get; set; }
    }

    public class Tmsdata1
    {
        public string vertical_id { get; set; }
        public string environment { get; set; }
        public string vertical { get; set; }
        public string source { get; set; }
        public string page_type { get; set; }
    }

    public class Query
    {
        public string rows { get; set; }
        public string keyword { get; set; }
        public string paylivery { get; set; }
        public string PRICE_FROM { get; set; }
        public string PRICE_TO { get; set; }
        public string treeAttributes { get; set; }
    }

    public class Runtimeconfig
    {
        public string context { get; set; }
        public string app { get; set; }
    }

}
