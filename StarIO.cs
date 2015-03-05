namespace SharpieIO {

	// @interface BluetoothPort : NSObject <NSStreamDelegate>
	[BaseType (typeof (NSObject))]
	interface BluetoothPort : NSStreamDelegate {

		// -(id)initWithPortName:(NSString *)portName portSettings:(NSString *)portSettings timeout:(u_int32_t)timeout;
		[Export ("initWithPortName:portSettings:timeout:")]
		IntPtr Constructor (string portName, string portSettings, uint timeout);

		// @property (readonly, getter = isConnected) BOOL connected;
		[Export ("connected")]
		bool Connected { [Bind ("isConnected")] get; }

		// @property (readwrite) u_int32_t endCheckedBlockTimeoutMillis;
		[Export ("endCheckedBlockTimeoutMillis")]
		uint EndCheckedBlockTimeoutMillis { get; set; }

		// @property (assign, nonatomic) NSInteger dataTimeoutSeconds;
		[Export ("dataTimeoutSeconds", ArgumentSemantic.UnsafeUnretained)]
		nint DataTimeoutSeconds { get; set; }

		// @property (readonly, retain) NSString * firmwareInformation;
		[Export ("firmwareInformation", ArgumentSemantic.Retain)]
		string FirmwareInformation { get; }

		// @property (readonly, retain) NSMutableArray * dipSwitchInformation;
		[Export ("dipSwitchInformation", ArgumentSemantic.Retain)]
		NSMutableArray DipSwitchInformation { get; }

		// @property (readonly, assign) BOOL isDKAirCash;
		[Export ("isDKAirCash", ArgumentSemantic.UnsafeUnretained)]
		bool IsDKAirCash { get; }

		// -(BOOL)open;
		[Export ("open")]
		bool Open ();

		// -(int)write:(NSData *)data;
		[Export ("write:")]
		int Write (NSData data);

		// -(NSData *)read:(NSUInteger)bytesToRead;
		[Export ("read:")]
		NSData Read (nuint bytesToRead);

		// -(BOOL)getParsedStatus:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
		[Export ("getParsedStatus:level:")]
		bool GetParsedStatus (StarPrinterStatus_2_ starPrinterStatus, uint level);

		// -(BOOL)getOnlineStatus:(BOOL *)onlineStatus;
		[Export ("getOnlineStatus:")]
		bool GetOnlineStatus (sbyte onlineStatus);

		// -(BOOL)retrieveFirmwareInformation;
		[Export ("retrieveFirmwareInformation")]
		bool RetrieveFirmwareInformation ();

		// -(BOOL)retrieveFirmwareInformation2;
		[Export ("retrieveFirmwareInformation2")]
		bool RetrieveFirmwareInformation2 ();

		// -(BOOL)retrieveDipSwitchInformation;
		[Export ("retrieveDipSwitchInformation")]
		bool RetrieveDipSwitchInformation ();

		// -(NSInteger)retrieveButtonSecurityTimeout;
		[Export ("retrieveButtonSecurityTimeout")]
		nint RetrieveButtonSecurityTimeout ();

		// -(BOOL)beginCheckedBlock:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
		[Export ("beginCheckedBlock:level:")]
		bool BeginCheckedBlock (StarPrinterStatus_2_ starPrinterStatus, uint level);

		// -(BOOL)endCheckedBlock:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
		[Export ("endCheckedBlock:level:")]
		bool EndCheckedBlock (StarPrinterStatus_2_ starPrinterStatus, uint level);

		// -(void)close;
		[Export ("close")]
		void Close ();

		// -(BOOL)disconnect;
		[Export ("disconnect")]
		bool Disconnect ();

		// -(BOOL)startDataCancel;
		[Export ("startDataCancel")]
		bool StartDataCancel ();
	}

	// @interface Lock : NSObject
	[BaseType (typeof (NSObject))]
	interface Lock {

		// +(Lock *)sharedManager;
		[Static, Export ("sharedManager")]
		Lock SharedManager ();

		// -(void)lock;
		[Export ("lock")]
		void Lock ();

		// -(void)unlock;
		[Export ("unlock")]
		void Unlock ();
	}

	// @interface WBluetoothPort : NSObject <NSStreamDelegate>
	[BaseType (typeof (NSObject))]
	interface WBluetoothPort : NSStreamDelegate {

		// -(id)initWithPortName:(NSString *)portName portSettings:(NSString *)portSettings timeout:(u_int32_t)timeout;
		[Export ("initWithPortName:portSettings:timeout:")]
		IntPtr Constructor (string portName, string portSettings, uint timeout);

		// @property (readonly, getter = isConnected) BOOL connected;
		[Export ("connected")]
		bool Connected { [Bind ("isConnected")] get; }

		// @property (readwrite) u_int32_t endCheckedBlockTimeoutMillis;
		[Export ("endCheckedBlockTimeoutMillis")]
		uint EndCheckedBlockTimeoutMillis { get; set; }

		// @property (readonly, retain) NSString * firmwareInformation;
		[Export ("firmwareInformation", ArgumentSemantic.Retain)]
		string FirmwareInformation { get; }

		// -(BOOL)open;
		[Export ("open")]
		bool Open ();

		// -(int32_t)write:(NSData *)data;
		[Export ("write:")]
		int Write (NSData data);

		// -(NSData *)read:(NSUInteger)bytesToRead;
		[Export ("read:")]
		NSData Read (nuint bytesToRead);

		// -(BOOL)getParsedStatus:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
		[Export ("getParsedStatus:level:")]
		bool GetParsedStatus (StarPrinterStatus_2_ starPrinterStatus, uint level);

		// -(BOOL)getParsedStatus:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level timeout:(__darwin_time_t)timeoutSec;
		[Export ("getParsedStatus:level:timeout:")]
		bool GetParsedStatus (StarPrinterStatus_2_ starPrinterStatus, uint level, nint timeoutSec);

		// -(BOOL)retrieveFirmwareInformation;
		[Export ("retrieveFirmwareInformation")]
		bool RetrieveFirmwareInformation ();

		// -(BOOL)retrieveDipSwitchInformation;
		[Export ("retrieveDipSwitchInformation")]
		bool RetrieveDipSwitchInformation ();

		// -(BOOL)getOnlineStatus:(BOOL *)onlineStatus;
		[Export ("getOnlineStatus:")]
		bool GetOnlineStatus (sbyte onlineStatus);

		// -(BOOL)beginCheckedBlock;
		[Export ("beginCheckedBlock")]
		bool BeginCheckedBlock ();

		// -(BOOL)endCheckedBlock;
		[Export ("endCheckedBlock")]
		bool EndCheckedBlock ();

		// -(void)close;
		[Export ("close")]
		void Close ();
	}

	// @interface PortException : NSException
	[BaseType (typeof (NSException))]
	interface PortException {

	}

	// @interface PortInfo : NSObject
	[BaseType (typeof (NSObject))]
	interface PortInfo {

		// -(id)initWithPortName:(NSString *)portName_ macAddress:(NSString *)macAddress_ modelName:(NSString *)modelName_;
		[Export ("initWithPortName:macAddress:modelName:")]
		IntPtr Constructor (string portName_, string macAddress_, string modelName_);

		// @property (readonly, retain) NSString * portName;
		[Export ("portName", ArgumentSemantic.Retain)]
		string PortName { get; }

		// @property (readonly, retain) NSString * macAddress;
		[Export ("macAddress", ArgumentSemantic.Retain)]
		string MacAddress { get; }

		// @property (readonly, retain) NSString * modelName;
		[Export ("modelName", ArgumentSemantic.Retain)]
		string ModelName { get; }

		// @property (readonly, getter = isConnected) BOOL connected;
		[Export ("connected")]
		bool Connected { [Bind ("isConnected")] get; }
	}

	// @interface SMPort : NSObject
	[BaseType (typeof (NSObject))]
	interface SMPort {

		// -(id)init:(NSString *)portName :(NSString *)portSettings :(u_int32_t)ioTimeoutMillis;
		[Export ("init:::")]
		IntPtr Constructor (string portName, string portSettings, uint ioTimeoutMillis);

		// @property (assign, readwrite, nonatomic) u_int32_t endCheckedBlockTimeoutMillis;
		[Export ("endCheckedBlockTimeoutMillis", ArgumentSemantic.UnsafeUnretained)]
		uint EndCheckedBlockTimeoutMillis { get; set; }

		// +(NSString *)StarIOVersion;
		[Static, Export ("StarIOVersion")]
		string StarIOVersion ();

		// +(NSArray *)searchPrinter;
		[Static, Export ("searchPrinter")]
		NSObject [] SearchPrinter ();

		// +(NSArray *)searchPrinter:(NSString *)target;
		[Static, Export ("searchPrinter:")]
		NSObject [] SearchPrinter (string target);

		// +(SMPort *)getPort:(NSString *)portName :(NSString *)portSettings :(u_int32_t)ioTimeoutMillis;
		[Static, Export ("getPort:::")]
		SMPort GetPort (string portName, string portSettings, uint ioTimeoutMillis);

		// +(void)releasePort:(SMPort *)port;
		[Static, Export ("releasePort:")]
		void ReleasePort (SMPort port);

		// -(u_int32_t)writePort:(const u_int8_t *)writeBuffer :(u_int32_t)offSet :(u_int32_t)size;
		[Export ("writePort:::")]
		uint WritePort (byte writeBuffer, uint offSet, uint size);

		// -(u_int32_t)readPort:(u_int8_t *)readBuffer :(u_int32_t)offSet :(u_int32_t)size;
		[Export ("readPort:::")]
		uint ReadPort (byte readBuffer, uint offSet, uint size);

		// -(void)getParsedStatus:(void *)starPrinterStatus :(u_int32_t)level;
		[Export ("getParsedStatus::")]
		void GetParsedStatus (void starPrinterStatus, uint level);

		// -(NSDictionary *)getFirmwareInformation;
		[Export ("getFirmwareInformation")]
		NSDictionary GetFirmwareInformation ();

		// -(NSDictionary *)getDipSwitchInformation;
		[Export ("getDipSwitchInformation")]
		NSDictionary GetDipSwitchInformation ();

		// -(_Bool)getOnlineStatus;
		[Export ("getOnlineStatus")]
		bool GetOnlineStatus ();

		// -(void)beginCheckedBlock:(void *)starPrinterStatus :(u_int32_t)level;
		[Export ("beginCheckedBlock::")]
		void BeginCheckedBlock (void starPrinterStatus, uint level);

		// -(void)endCheckedBlock:(void *)starPrinterStatus :(u_int32_t)level;
		[Export ("endCheckedBlock::")]
		void EndCheckedBlock (void starPrinterStatus, uint level);

		// -(BOOL)disconnect;
		[Export ("disconnect")]
		bool Disconnect ();

		// +(NSMutableData *)compressRasterData:(int32_t)width :(int32_t)height :(u_int8_t *)imageData :(NSString *)portSettings;
		[Static, Export ("compressRasterData::::")]
		NSMutableData CompressRasterData (int width, int height, byte imageData, string portSettings);

		// +(NSMutableData *)generateBitImageCommand:(int32_t)width :(int32_t)height :(u_int8_t *)imageData :(NSString *)portSettings;
		[Availability (Deprecated = Platform.iOS | Platform.Mac)]
		[Static, Export ("generateBitImageCommand::::")]
		NSMutableData GenerateBitImageCommand (int width, int height, byte imageData, string portSettings);

		// -(NSString *)portName;
		[Export ("portName")]
		string PortName ();

		// -(NSString *)portSettings;
		[Export ("portSettings")]
		string PortSettings ();

		// -(u_int32_t)timeoutMillis;
		[Export ("timeoutMillis")]
		uint TimeoutMillis ();

		// -(BOOL)connected;
		[Export ("connected")]
		bool Connected ();

		// +(void)setMACAddressSourceBlock:(NSString *(^)(EAAccessory *))macAddressSourceBlock;
		[Static, Export ("setMACAddressSourceBlock:")]
		void SetMACAddressSourceBlock (Func<EAAccessory, NSString> macAddressSourceBlock);
	}

	// @interface Port : SMPort
	[BaseType (typeof (SMPort))]
	interface Port {

		// +(Port *)getPort:(NSString *)portName :(NSString *)portSettings :(u_int32_t)ioTimeoutMillis;
		[Static, Export ("getPort:::")]
		Port GetPort (string portName, string portSettings, uint ioTimeoutMillis);
	}

	// @interface SMBluetoothManager : NSObject
	[BaseType (typeof (NSObject))]
	interface SMBluetoothManager {

		// -(id)initWithPortName:(NSString *)portName deviceType:(SMDeviceType)deviceType;
		[Export ("initWithPortName:deviceType:")]
		IntPtr Constructor (string portName, _SMDeviceType deviceType);

		// @property (readonly, retain) NSString * portName;
		[Export ("portName", ArgumentSemantic.Retain)]
		string PortName { get; }

		// @property (readonly, assign) SMDeviceType deviceType;
		[Export ("deviceType", ArgumentSemantic.UnsafeUnretained)]
		_SMDeviceType DeviceType { get; }

		// @property (readonly, assign) BOOL opened;
		[Export ("opened", ArgumentSemantic.UnsafeUnretained)]
		bool Opened { get; }

		// @property (retain) NSString * deviceName;
		[Export ("deviceName", ArgumentSemantic.Retain)]
		string DeviceName { get; set; }

		// @property (retain) NSString * iOSPortName;
		[Export ("iOSPortName", ArgumentSemantic.Retain)]
		string IOSPortName { get; set; }

		// @property (assign) BOOL autoConnect;
		[Export ("autoConnect", ArgumentSemantic.UnsafeUnretained)]
		bool AutoConnect { get; set; }

		// @property (assign) SMBluetoothSecurity security;
		[Export ("security", ArgumentSemantic.UnsafeUnretained)]
		_SMBluetoothSecurity Security { get; set; }

		// @property (retain) NSString * pinCode;
		[Export ("pinCode", ArgumentSemantic.Retain)]
		string PinCode { get; set; }

		// -(BOOL)open;
		[Export ("open")]
		bool Open ();

		// -(BOOL)loadSetting;
		[Export ("loadSetting")]
		bool LoadSetting ();

		// -(BOOL)apply;
		[Export ("apply")]
		bool Apply ();

		// -(void)close;
		[Export ("close")]
		void Close ();
	}
}
