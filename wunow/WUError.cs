using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wunow
{
    class WUError
    {
        const uint WU_S_SERVICE_STOP = 0x00240001;
        const uint WU_S_SELFUPDATE = 0x00240002;
        const uint WU_S_UPDATE_ERROR = 0x00240003;
        const uint WU_S_MARKED_FOR_DISCONNECT = 0x00240004;
        const uint WU_S_REBOOT_REQUIRED = 0x00240005;
        const uint WU_S_ALREADY_INSTALLED = 0x00240006;
        const uint WU_S_ALREADY_UNINSTALLED = 0x00240007;
        const uint WU_S_ALREADY_DOWNLOADED = 0x00240008;
        const uint WU_S_UH_INSTALLSTILLPENDING = 0x00242015;
        const uint WU_E_NO_SERVICE = 0x80240001;
        const uint WU_E_MAX_CAPACITY_REACHED = 0x80240002;
        const uint WU_E_UNKNOWN_ID = 0x80240003;
        const uint WU_E_NOT_INITIALIZED = 0x80240004;
        const uint WU_E_RANGEOVERLAP = 0x80240005;
        const uint WU_E_TOOMANYRANGES = 0x80240006;
        const uint WU_E_INVALIDINDEX = 0x80240007;
        const uint WU_E_ITEMNOTFOUND = 0x80240008;
        const uint WU_E_OPERATIONINPROGRESS = 0x80240009;
        const uint WU_E_COULDNOTCANCEL = 0x8024000A;
        const uint WU_E_CALL_CANCELLED = 0x8024000B;
        const uint WU_E_NOOP = 0x8024000C;
        const uint WU_E_XML_MISSINGDATA = 0x8024000D;
        const uint WU_E_XML_INVALID = 0x8024000E;
        const uint WU_E_CYCLE_DETECTED = 0x8024000F;
        const uint WU_E_TOO_DEEP_RELATION = 0x80240010;
        const uint WU_E_INVALID_RELATIONSHIP = 0x80240011;
        const uint WU_E_REG_VALUE_INVALID = 0x80240012;
        const uint WU_E_DUPLICATE_ITEM = 0x80240013;
        const uint WU_E_INVALID_INSTALL_REQUESTED = 0x80240014;
        const uint WU_E_INSTALL_NOT_ALLOWED = 0x80240016;
        const uint WU_E_NOT_APPLICABLE = 0x80240017;
        const uint WU_E_NO_USERTOKEN = 0x80240018;
        const uint WU_E_EXCLUSIVE_INSTALL_CONFLICT = 0x80240019;
        const uint WU_E_POLICY_NOT_SET = 0x8024001A;
        const uint WU_E_SELFUPDATE_IN_PROGRESS = 0x8024001B;
        const uint WU_E_INVALID_UPDATE = 0x8024001D;
        const uint WU_E_SERVICE_STOP = 0x8024001E;
        const uint WU_E_NO_CONNECTION = 0x8024001F;
        const uint WU_E_NO_INTERACTIVE_USER = 0x80240020;
        const uint WU_E_TIME_OUT = 0x80240021;
        const uint WU_E_ALL_UPDATES_FAILED = 0x80240022;
        const uint WU_E_EULAS_DECLINED = 0x80240023;
        const uint WU_E_NO_UPDATE = 0x80240024;
        const uint WU_E_USER_ACCESS_DISABLED = 0x80240025;
        const uint WU_E_INVALID_UPDATE_TYPE = 0x80240026;
        const uint WU_E_URL_TOO_LONG = 0x80240027;
        const uint WU_E_UNINSTALL_NOT_ALLOWED = 0x80240028;
        const uint WU_E_INVALID_PRODUCT_LICENSE = 0x80240029;
        const uint WU_E_MISSING_HANDLER = 0x8024002A;
        const uint WU_E_LEGACYSERVER = 0x8024002B;
        const uint WU_E_BIN_SOURCE_ABSENT = 0x8024002C;
        const uint WU_E_SOURCE_ABSENT = 0x8024002D;
        const uint WU_E_WU_DISABLED = 0x8024002E;
        const uint WU_E_CALL_CANCELLED_BY_POLICY = 0x8024002F;
        const uint WU_E_INVALID_PROXY_SERVER = 0x80240030;
        const uint WU_E_INVALID_FILE = 0x80240031;
        const uint WU_E_INVALID_CRITERIA = 0x80240032;
        const uint WU_E_EULA_UNAVAILABLE = 0x80240033;
        const uint WU_E_DOWNLOAD_FAILED = 0x80240034;
        const uint WU_E_UPDATE_NOT_PROCESSED = 0x80240035;
        const uint WU_E_INVALID_OPERATION = 0x80240036;
        const uint WU_E_NOT_SUPPORTED = 0x80240037;
        const uint WU_E_WINHTTP_INVALID_FILE = 0x80240038;
        const uint WU_E_TOO_MANY_RESYNC = 0x80240039;
        const uint WU_E_NO_SERVER_CORE_SUPPORT = 0x80240040;
        const uint WU_E_SYSPREP_IN_PROGRESS = 0x80240041;
        const uint WU_E_UNKNOWN_SERVICE = 0x80240042;
        const uint WU_E_NO_UI_SUPPORT = 0x80240043;
        const uint WU_E_PER_MACHINE_UPDATE_ACCESS_DENIED = 0x80240044;
        const uint WU_E_UNSUPPORTED_SEARCHSCOPE = 0x80240045;
        const uint WU_E_BAD_FILE_URL = 0x80240046;
        const uint WU_E_NOTSUPPORTED = 0x80240047;
        const uint WU_E_INVALID_NOTIFICATION_INFO = 0x80240048;
        const uint WU_E_UNEXPECTED = 0x80240FFF;
        const uint WU_E_MSI_WRONG_VERSION = 0x80241001;
        const uint WU_E_MSI_NOT_CONFIGURED = 0x80241002;
        const uint WU_E_MSP_DISABLED = 0x80241003;
        const uint WU_E_MSI_WRONG_APP_CONTEXT = 0x80241004;
        const uint WU_E_MSP_UNEXPECTED = 0x80241FFF;
        const uint WU_E_PT_SOAPCLIENT_BASE = 0x80244000;
        const uint WU_E_PT_SOAPCLIENT_INITIALIZE = 0x80244001;
        const uint WU_E_PT_SOAPCLIENT_OUTOFMEMORY = 0x80244002;
        const uint WU_E_PT_SOAPCLIENT_GENERATE = 0x80244003;
        const uint WU_E_PT_SOAPCLIENT_CONNECT = 0x80244004;
        const uint WU_E_PT_SOAPCLIENT_SEND = 0x80244005;
        const uint WU_E_PT_SOAPCLIENT_SERVER = 0x80244006;
        const uint WU_E_PT_SOAPCLIENT_SOAPFAULT = 0x80244007;
        const uint WU_E_PT_SOAPCLIENT_PARSEFAULT = 0x80244008;
        const uint WU_E_PT_SOAPCLIENT_READ = 0x80244009;
        const uint WU_E_PT_SOAPCLIENT_PARSE = 0x8024400A;
        const uint WU_E_PT_SOAP_VERSION = 0x8024400B;
        const uint WU_E_PT_SOAP_MUST_UNDERSTAND = 0x8024400C;
        const uint WU_E_PT_SOAP_CLIENT = 0x8024400D;
        const uint WU_E_PT_SOAP_SERVER = 0x8024400E;
        const uint WU_E_PT_WMI_ERROR = 0x8024400F;
        const uint WU_E_PT_EXCEEDED_MAX_SERVER_TRIPS = 0x80244010;
        const uint WU_E_PT_SUS_SERVER_NOT_SET = 0x80244011;
        const uint WU_E_PT_DOUBLE_INITIALIZATION = 0x80244012;
        const uint WU_E_PT_INVALID_COMPUTER_NAME = 0x80244013;
        const uint WU_E_PT_REFRESH_CACHE_REQUIRED = 0x80244015;
        const uint WU_E_PT_HTTP_STATUS_BAD_REQUEST = 0x80244016;
        const uint WU_E_PT_HTTP_STATUS_DENIED = 0x80244017;
        const uint WU_E_PT_HTTP_STATUS_FORBIDDEN = 0x80244018;
        const uint WU_E_PT_HTTP_STATUS_BAD_METHOD = 0x8024401A;
        const uint WU_E_PT_HTTP_STATUS_PROXY_AUTH_REQ = 0x8024401B;
        const uint WU_E_PT_HTTP_STATUS_REQUEST_TIMEOUT = 0x8024401C;
        const uint WU_E_PT_HTTP_STATUS_CONFLICT = 0x8024401D;
        const uint WU_E_PT_HTTP_STATUS_GONE = 0x8024401E;
        const uint WU_E_PT_HTTP_STATUS_SERVER_ERROR = 0x8024401F;
        const uint WU_E_PT_HTTP_STATUS_NOT_SUPPORTED = 0x80244020;
        const uint WU_E_PT_HTTP_STATUS_BAD_GATEWAY = 0x80244021;
        const uint WU_E_PT_HTTP_STATUS_SERVICE_UNAVAIL = 0x80244022;
        const uint WU_E_PT_HTTP_STATUS_GATEWAY_TIMEOUT = 0x80244023;
        const uint WU_E_PT_HTTP_STATUS_VERSION_NOT_SUP = 0x80244024;
        const uint WU_E_PT_FILE_LOCATIONS_CHANGED = 0x80244025;
        const uint WU_E_PT_REGISTRATION_NOT_SUPPORTED = 0x80244026;
        const uint WU_E_PT_NO_AUTH_PLUGINS_REQUESTED = 0x80244027;
        const uint WU_E_PT_NO_AUTH_COOKIES_CREATED = 0x80244028;
        const uint WU_E_PT_INVALID_CONFIG_PROP = 0x80244029;
        const uint WU_E_PT_CONFIG_PROP_MISSING = 0x8024402A;
        const uint WU_E_PT_HTTP_STATUS_NOT_MAPPED = 0x8024402B;
        const uint WU_E_PT_WINHTTP_NAME_NOT_RESOLVED = 0x8024402C;
        const uint WU_E_PT_SAME_REDIR_ID = 0x8024502D;
        const uint WU_E_PT_NO_MANAGED_RECOVER = 0x8024502E;
        const uint WU_E_PT_ECP_SUCCEEDED_WITH_ERRORS = 0x8024402F;
        const uint WU_E_PT_ECP_INIT_FAILED = 0x80244030;
        const uint WU_E_PT_ECP_INVALID_FILE_FORMAT = 0x80244031;
        const uint WU_E_PT_ECP_INVALID_METADATA = 0x80244032;
        const uint WU_E_PT_ECP_FAILURE_TO_EXTRACT_DIGEST = 0x80244033;
        const uint WU_E_PT_ECP_FAILURE_TO_DECOMPRESS_CAB_FILE = 0x80244034;
        const uint WU_E_PT_ECP_FILE_LOCATION_ERROR = 0x80244035;
        const uint WU_E_PT_CATALOG_SYNC_REQUIRED = 0x80240436;
        const uint WU_E_PT_UNEXPECTED = 0x80244FFF;
        const uint WU_E_REDIRECTOR_LOAD_XML = 0x80245001;
        const uint WU_E_REDIRECTOR_S_FALSE = 0x80245002;
        const uint WU_E_REDIRECTOR_ID_SMALLER = 0x80245003;
        const uint WU_E_REDIRECTOR_UNEXPECTED = 0x80245FFF;
        const uint WU_E_DRV_PRUNED = 0x8024C001;
        const uint WU_E_DRV_NOPROP_OR_LEGACY = 0x8024C002;
        const uint WU_E_DRV_REG_MISMATCH = 0x8024C003;
        const uint WU_E_DRV_NO_METADATA = 0x8024C004;
        const uint WU_E_DRV_MISSING_ATTRIBUTE = 0x8024C005;
        const uint WU_E_DRV_SYNC_FAILED = 0x8024C006;
        const uint WU_E_DRV_NO_PRINTER_CONTENT = 0x8024C007;
        const uint WU_E_DRV_UNEXPECTED = 0x8024CFFF;
        const uint WU_E_DS_SHUTDOWN = 0x80248000;
        const uint WU_E_DS_INUSE = 0x80248001;
        const uint WU_E_DS_INVALID = 0x80248002;
        const uint WU_E_DS_TABLEMISSING = 0x80248003;
        const uint WU_E_DS_TABLEINCORRECT = 0x80248004;
        const uint WU_E_DS_INVALIDTABLENAME = 0x80248005;
        const uint WU_E_DS_BADVERSION = 0x80248006;
        const uint WU_E_DS_NODATA = 0x80248007;
        const uint WU_E_DS_MISSINGDATA = 0x80248008;
        const uint WU_E_DS_MISSINGREF = 0x80248009;
        const uint WU_E_DS_UNKNOWNHANDLER = 0x8024800A;
        const uint WU_E_DS_CANTDELETE = 0x8024800B;
        const uint WU_E_DS_LOCKTIMEOUTEXPIRED = 0x8024800C;
        const uint WU_E_DS_NOCATEGORIES = 0x8024800D;
        const uint WU_E_DS_ROWEXISTS = 0x8024800E;
        const uint WU_E_DS_STOREFILELOCKED = 0x8024800F;
        const uint WU_E_DS_CANNOTREGISTER = 0x80248010;
        const uint WU_E_DS_UNABLETOSTART = 0x80248011;
        const uint WU_E_DS_DUPLICATEUPDATEID = 0x80248013;
        const uint WU_E_DS_UNKNOWNSERVICE = 0x80248014;
        const uint WU_E_DS_SERVICEEXPIRED = 0x80248015;
        const uint WU_E_DS_DECLINENOTALLOWED = 0x80248016;
        const uint WU_E_DS_TABLESESSIONMISMATCH = 0x80248017;
        const uint WU_E_DS_SESSIONLOCKMISMATCH = 0x80248018;
        const uint WU_E_DS_NEEDWINDOWSSERVICE = 0x80248019;
        const uint WU_E_DS_INVALIDOPERATION = 0x8024801A;
        const uint WU_E_DS_SCHEMAMISMATCH = 0x8024801B;
        const uint WU_E_DS_RESETREQUIRED = 0x8024801C;
        const uint WU_E_DS_IMPERSONATED = 0x8024801D;
        const uint WU_E_DS_UNEXPECTED = 0x80248FFF;
        const uint WU_E_INVENTORY_PARSEFAILED = 0x80249001;
        const uint WU_E_INVENTORY_GET_INVENTORY_TYPE_FAILED = 0x80249002;
        const uint WU_E_INVENTORY_RESULT_UPLOAD_FAILED = 0x80249003;
        const uint WU_E_INVENTORY_UNEXPECTED = 0x80249004;
        const uint WU_E_INVENTORY_WMI_ERROR = 0x80249005;
        const uint WU_E_AU_NOSERVICE = 0x8024A000;
        const uint WU_E_AU_NONLEGACYSERVER = 0x8024A002;
        const uint WU_E_AU_LEGACYCLIENTDISABLED = 0x8024A003;
        const uint WU_E_AU_PAUSED = 0x8024A004;
        const uint WU_E_AU_NO_REGISTERED_SERVICE = 0x8024A005;
        const uint WU_E_AU_DETECT_SVCID_MISMATCH = 0x8024A006;
        const uint WU_E_AU_UNEXPECTED = 0x8024AFFF;
        const uint WU_E_UH_REMOTEUNAVAILABLE = 0x80242000;
        const uint WU_E_UH_LOCALONLY = 0x80242001;
        const uint WU_E_UH_UNKNOWNHANDLER = 0x80242002;
        const uint WU_E_UH_REMOTEALREADYACTIVE = 0x80242003;
        const uint WU_E_UH_DOESNOTSUPPORTACTION = 0x80242004;
        const uint WU_E_UH_WRONGHANDLER = 0x80242005;
        const uint WU_E_UH_INVALIDMETADATA = 0x80242006;
        const uint WU_E_UH_INSTALLERHUNG = 0x80242007;
        const uint WU_E_UH_OPERATIONCANCELLED = 0x80242008;
        const uint WU_E_UH_BADHANDLERXML = 0x80242009;
        const uint WU_E_UH_CANREQUIREINPUT = 0x8024200A;
        const uint WU_E_UH_INSTALLERFAILURE = 0x8024200B;
        const uint WU_E_UH_FALLBACKTOSELFCONTAINED = 0x8024200C;
        const uint WU_E_UH_NEEDANOTHERDOWNLOAD = 0x8024200D;
        const uint WU_E_UH_NOTIFYFAILURE = 0x8024200E;
        const uint WU_E_UH_INCONSISTENT_FILE_NAMES = 0x8024200F;
        const uint WU_E_UH_FALLBACKERROR = 0x80242010;
        const uint WU_E_UH_TOOMANYDOWNLOADREQUESTS = 0x80242011;
        const uint WU_E_UH_UNEXPECTEDCBSRESPONSE = 0x80242012;
        const uint WU_E_UH_BADCBSPACKAGEID = 0x80242013;
        const uint WU_E_UH_POSTREBOOTSTILLPENDING = 0x80242014;
        const uint WU_E_UH_POSTREBOOTRESULTUNKNOWN = 0x80242015;
        const uint WU_E_UH_POSTREBOOTUNEXPECTEDSTATE = 0x80242016;
        const uint WU_E_UH_NEW_SERVICING_STACK_REQUIRED = 0x80242017;
        const uint WU_E_UH_CALLED_BACK_FAILURE = 0x80242018;
        const uint WU_E_UH_CUSTOMINSTALLER_INVALID_SIGNATURE = 0x80242019;
        const uint WU_E_UH_UNSUPPORTED_INSTALLCONTEXT = 0x8024201A;
        const uint WU_E_UH_INVALID_TARGETSESSION = 0x8024201B;
        const uint WU_E_UH_UNEXPECTED = 0x80242FFF;
        const uint WU_E_DM_URLNOTAVAILABLE = 0x80246001;
        const uint WU_E_DM_INCORRECTFILEHASH = 0x80246002;
        const uint WU_E_DM_UNKNOWNALGORITHM = 0x80246003;
        const uint WU_E_DM_NEEDDOWNLOADREQUEST = 0x80246004;
        const uint WU_E_DM_NONETWORK = 0x80246005;
        const uint WU_E_DM_WRONGBITSVERSION = 0x80246006;
        const uint WU_E_DM_NOTDOWNLOADED = 0x80246007;
        const uint WU_E_DM_FAILTOCONNECTTOBITS = 0x80246008;
        const uint WU_E_DM_BITSTRANSFERERROR = 0x80246009;
        const uint WU_E_DM_DOWNLOADLOCATIONCHANGED = 0x8024600A;
        const uint WU_E_DM_CONTENTCHANGED = 0x8024600B;
        const uint WU_E_DM_UNEXPECTED = 0x80246FFF;
        const uint WU_E_SETUP_INVALID_INFDATA = 0x8024D001;
        const uint WU_E_SETUP_INVALID_IDENTDATA = 0x8024D002;
        const uint WU_E_SETUP_ALREADY_INITIALIZED = 0x8024D003;
        const uint WU_E_SETUP_NOT_INITIALIZED = 0x8024D004;
        const uint WU_E_SETUP_SOURCE_VERSION_MISMATCH = 0x8024D005;
        const uint WU_E_SETUP_TARGET_VERSION_GREATER = 0x8024D006;
        const uint WU_E_SETUP_REGISTRATION_FAILED = 0x8024D007;
        const uint WU_E_SELFUPDATE_SKIP_ON_FAILURE = 0x8024D008;
        const uint WU_E_SETUP_SKIP_UPDATE = 0x8024D009;
        const uint WU_E_SETUP_UNSUPPORTED_CONFIGURATION = 0x8024D00A;
        const uint WU_E_SETUP_BLOCKED_CONFIGURATION = 0x8024D00B;
        const uint WU_E_SETUP_REBOOT_TO_FIX = 0x8024D00C;
        const uint WU_E_SETUP_ALREADYRUNNING = 0x8024D00D;
        const uint WU_E_SETUP_REBOOTREQUIRED = 0x8024D00E;
        const uint WU_E_SETUP_HANDLER_EXEC_FAILURE = 0x8024D00F;
        const uint WU_E_SETUP_INVALID_REGISTRY_DATA = 0x8024D010;
        const uint WU_E_SELFUPDATE_REQUIRED = 0x8024D011;
        const uint WU_E_SELFUPDATE_REQUIRED_ADMIN = 0x8024D012;
        const uint WU_E_SETUP_WRONG_SERVER_VERSION = 0x8024D013;
        const uint WU_E_SETUP_UNEXPECTED = 0x8024DFFF;
        const uint WU_E_EE_UNKNOWN_EXPRESSION = 0x8024E001;
        const uint WU_E_EE_INVALID_EXPRESSION = 0x8024E002;
        const uint WU_E_EE_MISSING_METADATA = 0x8024E003;
        const uint WU_E_EE_INVALID_VERSION = 0x8024E004;
        const uint WU_E_EE_NOT_INITIALIZED = 0x8024E005;
        const uint WU_E_EE_INVALID_ATTRIBUTEDATA = 0x8024E006;
        const uint WU_E_EE_CLUSTER_ERROR = 0x8024E007;
        const uint WU_E_EE_UNEXPECTED = 0x8024EFFF;
        const uint WU_E_INSTALLATION_RESULTS_UNKNOWN_VERSION = 0x80243001;
        const uint WU_E_INSTALLATION_RESULTS_INVALID_DATA = 0x80243002;
        const uint WU_E_INSTALLATION_RESULTS_NOT_FOUND = 0x80243003;
        const uint WU_E_TRAYICON_FAILURE = 0x80243004;
        const uint WU_E_NON_UI_MODE = 0x80243FFD;
        const uint WU_E_WUCLTUI_UNSUPPORTED_VERSION = 0x80243FFE;
        const uint WU_E_AUCLIENT_UNEXPECTED = 0x80243FFF;
        const uint WU_E_REPORTER_EVENTCACHECORRUPT = 0x8024F001;
        const uint WU_E_REPORTER_EVENTNAMESPACEPARSEFAILED = 0x8024F002;
        const uint WU_E_INVALID_EVENT = 0x8024F003;
        const uint WU_E_SERVER_BUSY = 0x8024F004;
        const uint WU_E_CALLBACK_COOKIE_NOT_FOUND = 0x8024F005;
        const uint WU_E_REPORTER_UNEXPECTED = 0x8024FFFF;
        const uint WU_E_OL_INVALID_SCANFILE = 0x80247001;
        const uint WU_E_OL_NEWCLIENT_REQUIRED = 0x80247002;
        const uint WU_E_OL_UNEXPECTED = 0x80247FFF;

        public static string GetHRMessage(int hresult)
        {
            uint u = (uint)hresult;
            return _wuErrorMessage[u];
        }
        private static readonly Dictionary<uint, string> _wuErrorMessage = new Dictionary<uint, string>
{
    { 0x00240001, "Windows Update Agent was stopped successfully." },
    { 0x00240002, "Windows Update Agent updated itself." },
    { 0x00240003, "Operation completed successfully but there were errors applying the updates." },
    { 0x00240004, "A callback was marked to be disconnected later because the request to disconnect the operation came while a callback was executing." },
    { 0x00240005, "The system must be restarted to complete installation of the update." },
    { 0x00240006, "The update to be installed is already installed on the system." },
    { 0x00240007, "The update to be removed is not installed on the system." },
    { 0x00240008, "The update to be downloaded has already been downloaded." },
    { 0x00242015, "The installation operation for the update is still in progress." },
    { 0x80240001, "Windows Update Agent was unable to provide the service." },
    { 0x80240002, "The maximum capacity of the service was exceeded." },
    { 0x80240003, "An ID cannot be found." },
    { 0x80240004, "The object could not be initialized." },
    { 0x80240005, "The update handler requested a byte range overlapping a previously requested range." },
    { 0x80240006, "The requested number of byte ranges exceeds the maximum number (2^31 - 1)." },
    { 0x80240007, "The index to a collection was invalid." },
    { 0x80240008, "The key for the item queried could not be found." },
    { 0x80240009, "Another conflicting operation was in progress. Some operations such as installation cannot be performed twice simultaneously." },
    { 0x8024000A, "Cancellation of the operation was not allowed." },
    { 0x8024000B, "Operation was cancelled." },
    { 0x8024000C, "No operation was required." },
    { 0x8024000D, "Windows Update Agent could not find required information in the update's XML data." },
    { 0x8024000E, "Windows Update Agent found invalid information in the update's XML data." },
    { 0x8024000F, "Circular update relationships were detected in the metadata." },
    { 0x80240010, "Update relationships too deep to evaluate were evaluated." },
    { 0x80240011, "An invalid update relationship was detected." },
    { 0x80240012, "An invalid registry value was read." },
    { 0x80240013, "Operation tried to add a duplicate item to a list." },
    { 0x80240014, "Updates requested for install are not installable by caller." },
    { 0x80240016, "Operation tried to install while another installation was in progress or the system was pending a mandatory restart." },
    { 0x80240017, "Operation was not performed because there are no applicable updates." },
    { 0x80240018, "Operation failed because a required user token is missing." },
    { 0x80240019, "An exclusive update cannot be installed with other updates at the same time." },
    { 0x8024001A, "A policy value was not set." },
    { 0x8024001B, "The operation could not be performed because the Windows Update Agent is self-updating." },
    { 0x8024001D, "An update contains invalid metadata." },
    { 0x8024001E, "Operation did not complete because the service or system was being shut down." },
    { 0x8024001F, "Operation did not complete because the network connection was unavailable." },
    { 0x80240020, "Operation did not complete because there is no logged-on interactive user." },
    { 0x80240021, "Operation did not complete because it timed out." },
    { 0x80240022, "Operation failed for all the updates." },
    { 0x80240023, "The license terms for all updates were declined." },
    { 0x80240024, "There are no updates." },
    { 0x80240025, "Group Policy settings prevented access to Windows Update." },
    { 0x80240026, "The type of update is invalid." },
    { 0x80240027, "The URL exceeded the maximum length." },
    { 0x80240028, "The update could not be uninstalled because the request did not originate from a WSUS server." },
    { 0x80240029, "Search may have missed some updates before there is an unlicensed application on the system." },
    { 0x8024002A, "A component required to detect applicable updates was missing." },
    { 0x8024002B, "An operation did not complete because it requires a newer version of server." },
    { 0x8024002C, "A delta-compressed update could not be installed because it required the source." },
    { 0x8024002D, "A full-file update could not be installed because it required the source." },
    { 0x8024002E, "Access to an unmanaged server is not allowed." },
    { 0x8024002F, "Operation did not complete because the DisableWindowsUpdateAccess policy was set." },
    { 0x80240030, "The format of the proxy list was invalid." },
    { 0x80240031, "The file is in the wrong format." },
    { 0x80240032, "The search criteria string was invalid." },
    { 0x80240033, "License terms could not be downloaded." },
    { 0x80240034, "Update failed to download." },
    { 0x80240035, "The update was not processed." },
    { 0x80240036, "The object's current state did not allow the operation." },
    { 0x80240037, "The functionality for the operation is not supported." },
    { 0x80240038, "The downloaded file has an unexpected content type." },
    { 0x80240039, "Agent is asked by server to resync too many times." },
    { 0x80240040, "WUA API method does not run on Server Core installation." },
    { 0x80240041, "Service is not available while sysprep is running." },
    { 0x80240042, "The update service is no longer registered with AU." },
    { 0x80240043, "There is no support for WUA UI." },
    { 0x80240044, "Only administrators can perform this operation on per-machine updates." },
    { 0x80240045, "A search was attempted with a scope that is not currently supported for this type of search." },
    { 0x80240046, "The URL does not point to a file." },
    { 0x80240047, "The operation requested is not supported." },
    { 0x80240048, "The featured update notification info returned by the server is invalid." },
    { 0x80240FFF, "An operation failed due to reasons not covered by another error code." },
    { 0x80241001, "Search may have missed some updates because the Windows Installer is less than version 3.1." },
    { 0x80241002, "Search may have missed some updates because the Windows Installer is not configured." },
    { 0x80241003, "Search may have missed some updates because policy has disabled Windows Installer patching." },
    { 0x80241004, "An update could not be applied because the application is installed per-user." },
    { 0x80241FFF, "Search may have missed some updates because there was a failure of the Windows Installer." },
    { 0x80244000, "WU_E_PT_SOAPCLIENT_* error codes map to the SOAPCLIENT_ERROR enum of the ATL Server Library." },
    { 0x80244001, "Same as SOAPCLIENT_INITIALIZE_ERROR - initialization of the SOAP client failed, possibly because of an MSXML installation failure." },
    { 0x80244002, "Same as SOAPCLIENT_OUTOFMEMORY - SOAP client failed because it ran out of memory." },
    { 0x80244003, "Same as SOAPCLIENT_GENERATE_ERROR - SOAP client failed to generate the request." },
    { 0x80244004, "Same as SOAPCLIENT_CONNECT_ERROR - SOAP client failed to connect to the server." },
    { 0x80244005, "Same as SOAPCLIENT_SEND_ERROR - SOAP client failed to send a message for reasons of WU_E_WINHTTP_* error codes." },
    { 0x80244006, "Same as SOAPCLIENT_SERVER_ERROR - SOAP client failed because there was a server error." },
    { 0x80244007, "Same as SOAPCLIENT_SOAPFAULT - SOAP client failed because there was a SOAP fault for reasons of WU_E_PT_SOAP_* error codes." },
    { 0x80244008, "Same as SOAPCLIENT_PARSEFAULT_ERROR - SOAP client failed to parse a SOAP fault." },
    { 0x80244009, "Same as SOAPCLIENT_READ_ERROR - SOAP client failed while reading the response from the server." },
    { 0x8024400A, "Same as SOAPCLIENT_PARSE_ERROR - SOAP client failed to parse the response from the server." },
    { 0x8024400B, "Same as SOAP_E_VERSION_MISMATCH - SOAP client found an unrecognizable namespace for the SOAP envelope." },
    { 0x8024400C, "Same as SOAP_E_MUST_UNDERSTAND - SOAP client was unable to understand a header." },
    { 0x8024400D, "Same as SOAP_E_CLIENT - SOAP client found the message was malformed; fix before resending." },
    { 0x8024400E, "Same as SOAP_E_SERVER - The SOAP message could not be processed due to a server error; resend later." },
    { 0x8024400F, "There was an unspecified Windows Management Instrumentation (WMI) error." },
    { 0x80244010, "The number of round trips to the server exceeded the maximum limit." },
    { 0x80244011, "WUServer policy value is missing in the registry." },
    { 0x80244012, "Initialization failed because the object was already initialized." },
    { 0x80244013, "The computer name could not be determined." },
    { 0x80244015, "The reply from the server indicates that the server was changed or the cookie was invalid; refresh the state of the internal cache and retry." },
    { 0x80244016, "Same as HTTP status 400 - the server could not process the request due to invalid syntax." },
    { 0x80244017, "Same as HTTP status 401 - the requested resource requires user authentication." },
    { 0x80244018, "Same as HTTP status 403 - server understood the request, but declined to fulfill it." },
    { 0x8024401A, "Same as HTTP status 405 - the HTTP method is not allowed." },
    { 0x8024401B, "Same as HTTP status 407 - proxy authentication is required." },
    { 0x8024401C, "Same as HTTP status 408 - the server timed out waiting for the request." },
    { 0x8024401D, "Same as HTTP status 409 - the request was not completed due to a conflict with the current state of the resource." },
    { 0x8024401E, "Same as HTTP status 410 - requested resource is no longer available at the server." },
    { 0x8024401F, "Same as HTTP status 500 - an error internal to the server prevented fulfilling the request." },
    { 0x80244020, "Same as HTTP status 500 - server does not support the functionality required to fulfill the request." },
    { 0x80244021, "Same as HTTP status 502 - the server, while acting as a gateway or proxy, received an invalid response from the upstream server it accessed in attempting to fulfill the request." },
    { 0x80244022, "Same as HTTP status 503 - the service is temporarily overloaded." },
    { 0x80244023, "Same as HTTP status 503 - the request was timed out waiting for a gateway." },
    { 0x80244024, "Same as HTTP status 505 - the server does not support the HTTP protocol version used for the request." },
    { 0x80244025, "Operation failed due to a changed file location; refresh internal state and resend." },
    { 0x80244026, "Operation failed because Windows Update Agent does not support registration with a non-WSUS server." },
    { 0x80244027, "The server returned an empty authentication information list." },
    { 0x80244028, "Windows Update Agent was unable to create any valid authentication cookies." },
    { 0x80244029, "A configuration property value was wrong." },
    { 0x8024402A, "A configuration property value was missing." },
    { 0x8024402B, "The HTTP request could not be completed and the reason did not correspond to any of the WU_E_PT_HTTP_* error codes." },
    { 0x8024402C, "Same as ERROR_WINHTTP_NAME_NOT_RESOLVED - the proxy server or target server name cannot be resolved." },
    { 0x8024502D, "Windows Update Agent failed to download a redirector cabinet file with a new redirectorId value from the server during the recovery." },
    { 0x8024502E, "A redirector recovery action did not complete because the server is managed." },
    { 0x8024402F, "External cab file processing completed with some errors." },
    { 0x80244030, "The external cab processor initialization did not complete." },
    { 0x80244031, "The format of a metadata file was invalid." },
    { 0x80244032, "External cab processor found invalid metadata." },
    { 0x80244033, "The file digest could not be extracted from an external cab file." },
    { 0x80244034, "An external cab file could not be decompressed." },
    { 0x80244035, "External cab processor was unable to get file locations." },
    { 0x80240436, "The server does not support category-specific search; Full catalog search has to be issued instead." },
    { 0x80244FFF, "A communication error not covered by another WU_E_PT_* error code." },
    { 0x80245001, "The redirector XML document could not be loaded into the DOM class." },
    { 0x80245002, "The redirector XML document is missing some required information." },
    { 0x80245003, "The redirectorId in the downloaded redirector cab is less than in the cached cab." },
    { 0x80245FFF, "The redirector failed for reasons not covered by another WU_E_REDIRECTOR_* error code." },
    { 0x8024C001, "A driver was skipped." },
    { 0x8024C002, "A property for the driver could not be found. It may not conform with required specifications." },
    { 0x8024C003, "The registry type read for the driver does not match the expected type." },
    { 0x8024C004, "The driver update is missing metadata." },
    { 0x8024C005, "The driver update is missing a required attribute." },
    { 0x8024C006, "Driver synchronization failed." },
    { 0x8024C007, "Information required for the synchronization of applicable printers is missing." },
    { 0x8024CFFF, "A driver error not covered by another WU_E_DRV_* code." },
    { 0x80248000, "An operation failed because Windows Update Agent is shutting down." },
    { 0x80248001, "An operation failed because the data store was in use." },
    { 0x80248002, "The current and expected states of the data store do not match." },
    { 0x80248003, "The data store is missing a table." },
    { 0x80248004, "The data store contains a table with unexpected columns." },
    { 0x80248005, "A table could not be opened because the table is not in the data store." },
    { 0x80248006, "The current and expected versions of the data store do not match." },
    { 0x80248007, "The information requested is not in the data store." },
    { 0x80248008, "The data store is missing required information or has a NULL in a table column that requires a non-null value." },
    { 0x80248009, "The data store is missing required information or has a reference to missing license terms, file, localized property or linked row." },
    { 0x8024800A, "The update was not processed because its update handler could not be recognized." },
    { 0x8024800B, "The update was not deleted because it is still referenced by one or more services." },
    { 0x8024800C, "The data store section could not be locked within the allotted time." },
    { 0x8024800D, "The category was not added because it contains no parent categories and is not a top-level category itself." },
    { 0x8024800E, "The row was not added because an existing row has the same primary key." },
    { 0x8024800F, "The data store could not be initialized because it was locked by another process." },
    { 0x80248010, "The data store is not allowed to be registered with COM in the current process." },
    { 0x80248011, "Could not create a data store object in another process." },
    { 0x80248013, "The server sent the same update to the client with two different revision IDs." },
    { 0x80248014, "An operation did not complete because the service is not in the data store." },
    { 0x80248015, "An operation did not complete because the registration of the service has expired." },
    { 0x80248016, "A request to hide an update was declined because it is a mandatory update or because it was deployed with a deadline." },
    { 0x80248017, "A table was not closed because it is not associated with the session." },
    { 0x80248018, "A table was not closed because it is not associated with the session." },
    { 0x80248019, "A request to remove the Windows Update service or to unregister it with Automatic Updates was declined because it is a built-in service and/or Automatic Updates cannot fall back to another service." },
    { 0x8024801A, "A request was declined because the operation is not allowed." },
    { 0x8024801B, "The schema of the current data store and the schema of a table in a backup XML document do not match." },
    { 0x8024801C, "The data store requires a session reset; release the session and retry with a new session." },
    { 0x8024801D, "A data store operation did not complete because it was requested with an impersonated identity." },
    { 0x80248FFF, "A data store error not covered by another WU_E_DS_* code." },
    { 0x80249001, "Parsing of the rule file failed." },
    { 0x80249002, "Failed to get the requested inventory type from the server." },
    { 0x80249003, "Failed to upload inventory result to the server." },
    { 0x80249004, "There was an inventory error not covered by another error code." },
    { 0x80249005, "A WMI error occurred when enumerating the instances for a particular class." },
    { 0x8024A000, "Automatic Updates was unable to service incoming requests." },
    { 0x8024A002, "The old version of the Automatic Updates client has stopped because the WSUS server has been upgraded." },
    { 0x8024A003, "The old version of the Automatic Updates client was disabled." },
    { 0x8024A004, "Automatic Updates was unable to process incoming requests because it was paused." },
    { 0x8024A005, "No unmanaged service is registered with AU." },
    { 0x8024A006, "The default service registered with AU changed during the search." },
    { 0x8024AFFF, "An Automatic Updates error not covered by another WU_E_AU * code." },
    { 0x80242000, "A request for a remote update handler could not be completed because no remote process is available." },
    { 0x80242001, "A request for a remote update handler could not be completed because the handler is local only." },
    { 0x80242002, "A request for an update handler could not be completed because the handler could not be recognized." },
    { 0x80242003, "A remote update handler could not be created because one already exists." },
    { 0x80242004, "A request for the handler to install (uninstall) an update could not be completed because the update does not support install (uninstall)." },
    { 0x80242005, "An operation did not complete because the wrong handler was specified." },
    { 0x80242006, "A handler operation could not be completed because the update contains invalid metadata." },
    { 0x80242007, "An operation could not be completed because the installer exceeded the time limit." },
    { 0x80242008, "An operation being done by the update handler was cancelled." },
    { 0x80242009, "An operation could not be completed because the handler-specific metadata is invalid." },
    { 0x8024200A, "A request to the handler to install an update could not be completed because the update requires user input." },
    { 0x8024200B, "The installer failed to install (uninstall) one or more updates." },
    { 0x8024200C, "The update handler should download self-contained content rather than delta-compressed content for the update." },
    { 0x8024200D, "The update handler did not install the update because it needs to be downloaded again." },
    { 0x8024200E, "The update handler failed to send notification of the status of the install (uninstall) operation." },
    { 0x8024200F, "The file names contained in the update metadata and in the update package are inconsistent." },
    { 0x80242010, "The update handler failed to fall back to the self-contained content." },
    { 0x80242011, "The update handler has exceeded the maximum number of download requests." },
    { 0x80242012, "The update handler has received an unexpected response from CBS." },
    { 0x80242013, "The update metadata contains an invalid CBS package identifier." },
    { 0x80242014, "The post-reboot operation for the update is still in progress." },
    { 0x80242015, "The result of the post-reboot operation for the update could not be determined." },
    { 0x80242016, "The state of the update after its post-reboot operation has completed is unexpected." },
    { 0x80242017, "The OS servicing stack must be updated before this update is downloaded or installed." },
    { 0x80242018, "A callback installer called back with an error." },
    { 0x80242019, "The custom installer signature did not match the signature required by the update." },
    { 0x8024201A, "The installer does not support the installation configuration." },
    { 0x8024201B, "The targeted session for isntall is invalid." },
    { 0x80242FFF, "An update handler error not covered by another WU_E_UH_* code." },
    { 0x80246001, "A download manager operation could not be completed because the requested file does not have a URL." },
    { 0x80246002, "A download manager operation could not be completed because the file digest was not recognized." },
    { 0x80246003, "A download manager operation could not be completed because the file metadata requested an unrecognized hash algorithm." },
    { 0x80246004, "An operation could not be completed because a download request is required from the download handler." },
    { 0x80246005, "A download manager operation could not be completed because the network connection was unavailable." },
    { 0x80246006, "A download manager operation could not be completed because the version of Background Intelligent Transfer Service (BITS) is incompatible." },
    { 0x80246007, "The update has not been downloaded." },
    { 0x80246008, "A download manager operation failed because the download manager was unable to connect the Background Intelligent Transfer Service (BITS)." },
    { 0x80246009, "A download manager operation failed because there was an unspecified Background Intelligent Transfer Service (BITS) transfer error." },
    { 0x8024600A, "A download must be restarted because the location of the source of the download has changed." },
    { 0x8024600B, "A download must be restarted because the update content changed in a new revision." },
    { 0x80246FFF, "There was a download manager error not covered by another WU_E_DM_* error code." },
    { 0x8024D001, "Windows Update Agent could not be updated because an INF file contains invalid information." },
    { 0x8024D002, "Windows Update Agent could not be updated because the wuident.cab file contains invalid information." },
    { 0x8024D003, "Windows Update Agent could not be updated because of an internal error that caused setup initialization to be performed twice." },
    { 0x8024D004, "Windows Update Agent could not be updated because setup initialization never completed successfully." },
    { 0x8024D005, "Windows Update Agent could not be updated because the versions specified in the INF do not match the actual source file versions." },
    { 0x8024D006, "Windows Update Agent could not be updated because a WUA file on the target system is newer than the corresponding source file." },
    { 0x8024D007, "Windows Update Agent could not be updated because regsvr32.exe returned an error." },
    { 0x8024D008, "An update to the Windows Update Agent was skipped because previous attempts to update have failed." },
    { 0x8024D009, "An update to the Windows Update Agent was skipped due to a directive in the wuident.cab file." },
    { 0x8024D00A, "Windows Update Agent could not be updated because the current system configuration is not supported." },
    { 0x8024D00B, "Windows Update Agent could not be updated because the system is configured to block the update." },
    { 0x8024D00C, "Windows Update Agent could not be updated because a restart of the system is required." },
    { 0x8024D00D, "Windows Update Agent setup is already running." },
    { 0x8024D00E, "Windows Update Agent setup package requires a reboot to complete installation." },
    { 0x8024D00F, "Windows Update Agent could not be updated because the setup handler failed during execution." },
    { 0x8024D010, "Windows Update Agent could not be updated because the registry contains invalid information." },
    { 0x8024D011, "Windows Update Agent must be updated before search can continue." },
    { 0x8024D012, "Windows Update Agent must be updated before search can continue.  An administrator is required to perform the operation." },
    { 0x8024D013, "Windows Update Agent could not be updated because the server does not contain update information for this version." },
    { 0x8024DFFF, "Windows Update Agent could not be updated because of an error not covered by another WU_E_SETUP_* error code." },
    { 0x8024E001, "An expression evaluator operation could not be completed because an expression was unrecognized." },
    { 0x8024E002, "An expression evaluator operation could not be completed because an expression was invalid." },
    { 0x8024E003, "An expression evaluator operation could not be completed because an expression contains an incorrect number of metadata nodes." },
    { 0x8024E004, "An expression evaluator operation could not be completed because the version of the serialized expression data is invalid." },
    { 0x8024E005, "The expression evaluator could not be initialized." },
    { 0x8024E006, "An expression evaluator operation could not be completed because there was an invalid attribute." },
    { 0x8024E007, "An expression evaluator operation could not be completed because the cluster state of the computer could not be determined." },
    { 0x8024EFFF, "There was an expression evaluator error not covered by another WU_E_EE_* error code." },
    { 0x80243001, "The results of download and installation could not be read from the registry due to an unrecognized data format version." },
    { 0x80243002, "The results of download and installation could not be read from the registry due to an invalid data format." },
    { 0x80243003, "The results of download and installation are not available; the operation may have failed to start." },
    { 0x80243004, "A failure occurred when trying to create an icon in the taskbar notification area." },
    { 0x80243FFD, "Unable to show UI when in non-UI mode; WU client UI modules may not be installed." },
    { 0x80243FFE, "Unsupported version of WU client UI exported functions." },
    { 0x80243FFF, "There was a user interface error not covered by another WU_E_AUCLIENT_* error code." },
    { 0x8024F001, "The event cache file was defective." },
    { 0x8024F002, "The XML in the event namespace descriptor could not be parsed." },
    { 0x8024F003, "The XML in the event namespace descriptor could not be parsed." },
    { 0x8024F004, "The server rejected an event because the server was too busy." },
    { 0x8024F005, "The specified callback cookie is not found." },
    { 0x8024FFFF, "There was a reporter error not covered by another error code." },
    { 0x80247001, "An operation could not be completed because the scan package was invalid." },
    { 0x80247002, "An operation could not be completed because the scan package requires a greater version of the Windows Update Agent." },
    { 0x80247FFF, "Search using the scan package failed." }
};

    }
}
