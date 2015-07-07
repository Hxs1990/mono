namespace System.Data {
	static partial class Res {















public const string ADP_Ascending = @"Ascending";
public const string ADP_CollectionIndexInt32 = @"Invalid index {0} for this {1} with Count={2}.";
public const string ADP_CollectionIndexString = @"An {0} with {1} '{2}' is not contained by this {3}.";
public const string ADP_CollectionInvalidType = @"The {0} only accepts non-null {1} type objects, not {2} objects.";
public const string ADP_CollectionIsNotParent = @"The {0} is already contained by another {1}.";
public const string ADP_CollectionIsParent = @"The {0} with is already contained by this {1}.";
public const string ADP_CollectionNullValue = @"The {0} only accepts non-null {1} type objects.";
public const string ADP_CollectionRemoveInvalidObject = @"Attempted to remove an {0} that is not contained by this {1}.";
public const string ADP_CollectionUniqueValue = @"The {0}.{1} is required to be unique, '{2}' already exists in the collection.";
public const string ADP_ConnectionAlreadyOpen = @"The connection was not closed. {0}";
public const string ADP_ConnectionStateMsg_Closed = @"The connection's current state is closed.";
public const string ADP_ConnectionStateMsg_Connecting = @"The connection's current state is connecting.";
public const string ADP_ConnectionStateMsg_Open = @"The connection's current state is open.";
public const string ADP_ConnectionStateMsg_OpenExecuting = @"The connection's current state is executing.";
public const string ADP_ConnectionStateMsg_OpenFetching = @"The connection's current state is fetching.";
public const string ADP_ConnectionStateMsg = @"The connection's current state: {0}.";
public const string ADP_ConnectionStringSyntax = @"Format of the initialization string does not conform to specification starting at index {0}.";
public const string ADP_DataReaderClosed = @"Invalid attempt to call {0} when reader is closed.";
public const string ADP_DelegatedTransactionPresent = @"Cannot enlist in the transaction because the connection is the primary connection for a delegated or promoted transaction.";
public const string ADP_Descending = @"Descending";
public const string ADP_EmptyString = @"Expecting non-empty string for '{0}' parameter.";
public const string ADP_InternalConnectionError = @"Internal DbConnection Error: {0}";
public const string ADP_InvalidDataDirectory = @"The DataDirectory substitute is not a string.";
public const string ADP_InvalidEnumerationValue = @"The {0} enumeration value, {1}, is invalid.";
public const string ADP_InvalidKey = @"Invalid keyword, contain one or more of 'no characters', 'control characters', 'leading or trailing whitespace' or 'leading semicolons'.";
public const string ADP_InvalidOffsetValue = @"Invalid parameter Offset value '{0}'. The value must be greater than or equal to 0.";
public const string ADP_InvalidValue = @"The value contains embedded nulls (\\u0000).";
public const string ADP_InvalidXMLBadVersion = @"Invalid Xml; can only parse elements of version one.";
public const string ADP_NoConnectionString = @"The ConnectionString property has not been initialized.";
public const string ADP_NonCLSException = @"A Non CLS Exception was caught.";
public const string ADP_NotAPermissionElement = @"Given security element is not a permission element.";
public const string ADP_OpenConnectionPropertySet = @"Not allowed to change the '{0}' property. {1}";
public const string ADP_PendingAsyncOperation = @"Can not start another operation while there is an asynchronous operation pending.";
public const string ADP_PermissionTypeMismatch = @"Type mismatch.";
public const string ADP_PooledOpenTimeout = @"Timeout expired.  The timeout period elapsed prior to obtaining a connection from the pool.  This may have occurred because all pooled connections were in use and max pool size was reached.";
public const string ADP_NonPooledOpenTimeout = @"Timeout attempting to open the connection.  The time period elapsed prior to attempting to open the connection has been exceeded.  This may have occurred because of too many simultaneous non-pooled connection attempts.";
public const string ADP_InvalidMixedUsageOfSecureAndClearCredential = @"Cannot use Credential with UserID, UID, Password, or PWD connection string keywords.";
public const string ADP_InvalidMixedUsageOfSecureCredentialAndIntegratedSecurity = @"Cannot use Credential with Integrated Security connection string keyword.";
public const string ADP_InvalidMixedUsageOfSecureCredentialAndContextConnection = @"Cannot use Credential with Context Connection keyword.";
public const string ADP_MustBeReadOnly = @"{0} must be marked as read only.";
public const string DataCategory_Data = @"Data";
public const string DataCategory_StateChange = @"StateChange";
public const string DataCategory_Update = @"Update";
public const string DbCommand_CommandTimeout = @"Time to wait for command to execute.";
public const string DbConnection_State = @"The ConnectionState indicating whether the connection is open or closed.";
public const string DbConnection_StateChange = @"Event triggered when the connection changes state.";
public const string DbParameter_DbType = @"The parameter generic type.";
public const string DbParameter_Direction = @"Input, output, or bidirectional parameter.";
public const string DbParameter_IsNullable = @"a design-time property used for strongly typed code-generation.";
public const string DbParameter_Offset = @"Offset in variable length data types.";
public const string DbParameter_ParameterName = @"Name of the parameter.";
public const string DbParameter_Size = @"Size of variable length data types (string & arrays).";
public const string DbParameter_SourceColumn = @"When used by a DataAdapter.Update, the source column name that is used to find the DataSetColumn name in the ColumnMappings. This is to copy a value between the parameter and a data row.";
public const string DbParameter_SourceVersion = @"When used by a DataAdapter.Update (UpdateCommand only), the version of the DataRow value that is used to update the data source.";
public const string DbParameter_SourceColumnNullMapping = @"When used by DataAdapter.Update, the parameter value is changed from DBNull.Value into (Int32)1 or (Int32)0 if non-null.";
public const string DbParameter_Value = @"Value of the parameter.";
public const string MDF_QueryFailed = @"Unable to build the '{0}' collection because execution of the SQL query failed. See the inner exception for details.";
public const string MDF_TooManyRestrictions = @"More restrictions were provided than the requested schema ('{0}') supports.";
public const string MDF_InvalidRestrictionValue = @" '{2}' is not a valid value for the '{1}' restriction of the '{0}' schema collection.";
public const string MDF_UndefinedCollection = @"The requested collection ({0}) is not defined.";
public const string MDF_UndefinedPopulationMechanism = @"The population mechanism '{0}' is not defined.";
public const string MDF_UnsupportedVersion = @"The requested collection ({0}) is not supported by this version of the provider.";
public const string MDF_MissingDataSourceInformationColumn = @"One of the required DataSourceInformation tables columns is missing.";
public const string MDF_IncorrectNumberOfDataSourceInformationRows = @"The DataSourceInformation table must contain exactly one row.";
public const string MDF_MissingRestrictionColumn = @" One or more of the required columns of the restrictions collection is missing.";
public const string MDF_MissingRestrictionRow = @" A restriction exists for which there is no matching row in the restrictions collection.";
public const string MDF_NoColumns = @"The schema table contains no columns.";
public const string MDF_UnableToBuildCollection = @"Unable to build schema collection '{0}';";
public const string MDF_AmbigousCollectionName = @"The collection name '{0}' matches at least two collections with the same name but with different case, but does not match any of them exactly.";
public const string MDF_CollectionNameISNotUnique = @"There are multiple collections named '{0}'.";
public const string MDF_DataTableDoesNotExist = @"The collection '{0}' is missing from the metadata XML.";
public const string MDF_InvalidXml = @"The metadata XML is invalid.";
public const string MDF_InvalidXmlMissingColumn = @"The metadata XML is invalid. The {0} collection must contain a {1} column and it must be a string column.";
public const string MDF_InvalidXmlInvalidValue = @"The metadata XML is invalid. The {1} column of the {0} collection must contain a non-empty string.";






public const string DataCategory_Action = @"Action";
public const string DataCategory_Behavior = @"Behavior";

public const string DataCategory_Fill = @"Fill";
public const string DataCategory_InfoMessage = @"InfoMessage";
public const string DataCategory_Mapping = @"Mapping";
public const string DataCategory_StatementCompleted = @"StatementCompleted";


public const string DataCategory_Udt = @"UDT";
public const string DataCategory_Notification = @"Notification";
public const string DataCategory_Schema = @"Schema";
public const string DataCategory_Xml = @"XML";

public const string DataCategory_Advanced = @"Advanced";
public const string DataCategory_Context = @"Context";
public const string DataCategory_Initialization = @"Initialization";
public const string DataCategory_Pooling = @"Pooling";
public const string DataCategory_NamedConnectionString = @"Named ConnectionString";
public const string DataCategory_Security = @"Security";
public const string DataCategory_Source = @"Source";
public const string DataCategory_Replication = @"Replication";
public const string DataCategory_ConnectionResilency = @"Connection Resiliency";



public const string ExtendedPropertiesDescr = @"The collection that holds custom user information.";


public const string DataSetCaseSensitiveDescr = @"Indicates whether comparing strings within the DataSet is case sensitive.";
public const string DataSetDataSetNameDescr = @"The name of this DataSet.";
public const string DataSetDefaultViewDescr = @"Indicates a custom ""view"" of the data contained by the DataSet. This view allows filtering, searching, and navigating through the custom data view.";
public const string DataSetEnforceConstraintsDescr = @"Indicates whether constraint rules are to be followed.";
public const string DataSetHasErrorsDescr = @"Indicates that the DataSet has errors.";
public const string DataSetLocaleDescr = @"Indicates a locale under which to compare strings within the DataSet.";
public const string DataSetNamespaceDescr = @"Indicates the XML uri namespace for the root element pointed at by this DataSet.";
public const string DataSetPrefixDescr = @"Indicates the prefix of the namespace used for this DataSet.";
public const string DataSetRelationsDescr = @"The collection that holds the relations for this DataSet.";
public const string DataSetTablesDescr = @"The collection that holds the tables for this DataSet.";
public const string DataSetMergeFailedDescr = @"Occurs when it is not possible to merge schemas for two tables with the same name.";
public const string DataSetInitializedDescr = @"Occurs after Initialization is finished.";
public const string DataSetDescr = @"Represents an in-memory cache of data.";


public const string DataTableCaseSensitiveDescr = @"Indicates whether comparing strings within the table is case sensitive.";
public const string DataTableChildRelationsDescr = @"Returns the child relations for this table.";
public const string DataTableColumnsDescr = @"The collection that holds the columns for this table.";
public const string DataTableConstraintsDescr = @"The collection that holds the constraints for this table.";
public const string DataTableDataSetDescr = @"Indicates the DataSet to which this table belongs.";
public const string DataTableDefaultViewDescr = @"This is the default DataView for the table.";
public const string DataTableDisplayExpressionDescr = @"The expression used to compute the data-bound value of this row.";
public const string DataTableHasErrorsDescr = @"Returns whether the table has errors.";
public const string DataTableLocaleDescr = @"Indicates a locale under which to compare strings within the table.";
public const string DataTableMinimumCapacityDescr = @"Indicates an initial starting size for this table.";
public const string DataTableNamespaceDescr = @"Indicates the XML uri namespace for the elements contained in this table.";
public const string DataTablePrefixDescr = @"Indicates the Prefix of the namespace used for this table in XML representation.";
public const string DataTableParentRelationsDescr = @"Returns the parent relations for this table.";
public const string DataTablePrimaryKeyDescr = @"Indicates the column(s) that represent the primary key for this table.";
public const string DataTableRowsDescr = @"Indicates the collection that holds the rows of data for this table.";
public const string DataTableTableNameDescr = @"Indicates the name used to look up this table in the Tables collection of a DataSet.";


public const string DataTableRowChangedDescr = @"Occurs after a row in the table has been successfully edited.";
public const string DataTableRowChangingDescr = @"Occurs when the row is being changed so that the event handler can modify or cancel the change. The user can modify values in the row and should throw an  exception to cancel the edit.";
public const string DataTableRowDeletedDescr = @"Occurs after a row in the table has been successfully deleted.";
public const string DataTableRowDeletingDescr = @"Occurs when a row in the table marked for deletion.  Throw an exception to cancel the deletion.";
public const string DataTableColumnChangingDescr = @"Occurs when a value has been submitted for this column.  The user can modify the proposed value and should throw an exception to cancel the edit.";
public const string DataTableColumnChangedDescr = @"Occurs when a value has been changed for this column.";
public const string DataTableRowsClearingDescr = @"Occurs prior to clearing all rows from the table.";
public const string DataTableRowsClearedDescr = @"Occurs after all rows in the table has been successfully cleared.";
public const string DataTableRowsNewRowDescr = @"Occurs after a new DataRow has been instantiated.";


public const string DataRelationRelationNameDescr = @"The name used to look up this relation in the Relations collection of a DataSet.";
public const string DataRelationChildColumnsDescr = @"Indicates the child columns of this relation.";
public const string DataRelationParentColumnsDescr = @"Indicates the parent columns of this relation.";
public const string DataRelationNested = @"Indicates whether relations are nested.";


public const string ForeignKeyConstraintDeleteRuleDescr = @"For deletions, indicates what kind of cascading should take place across this relation.";
public const string ForeignKeyConstraintUpdateRuleDescr = @"For updates, indicates what kind of cascading should take place across this relation.";
public const string ForeignKeyConstraintAcceptRejectRuleDescr = @"For accept and reject changes, indicates what kind of cascading should take place across this relation.";
public const string ForeignKeyConstraintChildColumnsDescr = @"Indicates the child columns of this constraint.";
public const string ForeignKeyConstraintParentColumnsDescr = @"Indicates the parent columns of this constraint.";
public const string ForeignKeyRelatedTableDescr = @"Indicates the child table of this constraint.";
public const string KeyConstraintColumnsDescr = @"Indicates the columns of this constraint.";
public const string KeyConstraintIsPrimaryKeyDescr = @"Indicates if this constraint is a primary key.";
public const string ConstraintNameDescr = @"Indicates the name of this constraint.";
public const string ConstraintTableDescr = @"Indicates the table of this constraint.";


public const string DataColumnAllowNullDescr = @"Indicates whether null values are allowed in this column.";
public const string DataColumnAutoIncrementDescr = @"Indicates whether the column automatically increments itself for new rows added to the table.  The type of this column must be Int16, Int32, or Int64.";
public const string DataColumnAutoIncrementSeedDescr = @"Indicates the starting value for an AutoIncrement column.";
public const string DataColumnAutoIncrementStepDescr = @"Indicates the increment used by an AutoIncrement column.";
public const string DataColumnCaptionDescr = @"Indicates the default user-interface caption for this column.";
public const string DataColumnColumnNameDescr = @"Indicates the name used to look up this column in the Columns collection of a DataTable.";
public const string DataColumnDataTableDescr = @"Returns the DataTable to which this column belongs.";
public const string DataColumnDataTypeDescr = @"Indicates the type of data stored in this column.";
public const string DataColumnDefaultValueDescr = @"Indicates the default column value used when adding new rows to the table.";
public const string DataColumnExpressionDescr = @"Indicates the value that this column computes for each row based on other columns instead of taking user input.";
public const string DataColumnMappingDescr = @"Indicates how this column persists in XML: as an attribute, element, simple content node, or nothing.";
public const string DataColumnNamespaceDescr = @"Indicates the XML uri for elements or attributes stored in this column.";
public const string DataColumnPrefixDescr = @"Indicates the Prefix used for this DataColumn in xml representation.";
public const string DataColumnOrdinalDescr = @"Indicates the index of this column in the Columns collection.";
public const string DataColumnReadOnlyDescr = @"Indicates whether this column allows changes once a row has been added to the table.";
public const string DataColumnUniqueDescr = @"Indicates whether this column should restrict its values in the rows of the table to be unique.";
public const string DataColumnMaxLengthDescr = @"Indicates the maximum length of the value this column allows.";
public const string DataColumnDateTimeModeDescr = @"Indicates DateTimeMode of this DataColumn.";



public const string DataViewAllowDeleteDescr = @"Indicates whether this DataView and the user interface associated with it allows deletes.";
public const string DataViewAllowEditDescr = @"Indicates whether this DataView and the user interface associated with it allows edits.";
public const string DataViewAllowNewDescr = @"Indicates whether this DataView and the user interface associated with it allows new rows to be added.";
public const string DataViewCountDescr = @"Returns the number of items currently in this view.";
public const string DataViewDataViewManagerDescr = @"This returns a pointer to back to the DataViewManager that owns this DataSet (if any).";
public const string DataViewIsOpenDescr = @"Indicates whether the view is open.";
public const string DataViewRowFilterDescr = @"Indicates an expression used to filter the data returned by this DataView.";
public const string DataViewRowStateFilterDescr = @"Indicates the versions of data returned by this DataView.";
public const string DataViewSortDescr = @"Indicates the names of the column and the order in which data is returned by this DataView.";
public const string DataViewApplyDefaultSortDescr = @"Indicates whether to use the default sort if the Sort property is not set.";
public const string DataViewTableDescr = @"Indicates the table this DataView uses to get data.";
public const string DataViewListChangedDescr = @"Indicates that the data returned by this DataView has somehow changed.";


public const string DataViewManagerDataSetDescr = @"Indicates the source of data for this DataViewManager.";
public const string DataViewManagerTableSettingsDescr = @"Indicates the sorting/filtering/state settings for any table in the corresponding DataSet.";




public const string Xml_SimpleTypeNotSupported = @"DataSet doesn't support 'union' or 'list' as simpleType.";
public const string Xml_MissingAttribute = @"Invalid {0} syntax: missing required '{1}' attribute.";
public const string Xml_ValueOutOfRange = @"Value '{1}' is invalid for attribute '{0}'.";
public const string Xml_AttributeValues = @"The value of attribute '{0}' should be '{1}' or '{2}'.";
public const string Xml_ElementTypeNotFound = @"Cannot find ElementType name='{0}'.";
public const string Xml_RelationParentNameMissing = @"Parent table name is missing in relation '{0}'.";
public const string Xml_RelationChildNameMissing = @"Child table name is missing in relation '{0}'.";
public const string Xml_RelationTableKeyMissing = @"Parent table key is missing in relation '{0}'.";
public const string Xml_RelationChildKeyMissing = @"Child table key is missing in relation '{0}'.";
public const string Xml_UndefinedDatatype = @"Undefined data type: '{0}'.";
public const string Xml_DatatypeNotDefined = @"Data type not defined.";
public const string Xml_InvalidField = @"Invalid XPath selection inside field node. Cannot find: {0}.";
public const string Xml_InvalidSelector = @"Invalid XPath selection inside selector node: {0}.";
public const string Xml_InvalidKey = @"Invalid 'Key' node inside constraint named: {0}.";
public const string Xml_DuplicateConstraint = @"The constraint name {0} is already used in the schema.";
public const string Xml_CannotConvert = @" Cannot convert '{0}' to type '{1}'.";
public const string Xml_MissingRefer = @"Missing '{0}' part in '{1}' constraint named '{2}'.";
public const string Xml_MismatchKeyLength = @"Invalid Relation definition: different length keys.";
public const string Xml_CircularComplexType = @"DataSet doesn't allow the circular reference in the ComplexType named '{0}'.";
public const string Xml_CannotInstantiateAbstract = @"DataSet cannot instantiate an abstract ComplexType for the node {0}.";
public const string Xml_MultipleTargetConverterError = @"An error occurred with the multiple target converter while writing an Xml Schema.  See the inner exception for details.";
public const string Xml_MultipleTargetConverterEmpty = @"An error occurred with the multiple target converter while writing an Xml Schema.  A null or empty string was returned.";

public const string Xml_MergeDuplicateDeclaration = @"Duplicated declaration '{0}'.";
public const string Xml_MissingTable = @"Cannot load diffGram. Table '{0}' is missing in the destination dataset.";
public const string Xml_MissingSQL = @"Cannot load diffGram. The 'sql' node is missing.";
public const string Xml_ColumnConflict = @"Column name '{0}' is defined for different mapping types.";
public const string Xml_InvalidPrefix = @"Prefix '{0}' is not valid, because it contains special characters.";
public const string Xml_NestedCircular = @"Circular reference in self-nested table '{0}'.";
public const string Xml_FoundEntity = @"DataSet cannot expand entities. Use XmlValidatingReader and set the EntityHandling property accordingly.";
public const string Xml_PolymorphismNotSupported = @"Type '{0}' does not implement IXmlSerializable interface therefore can not proceed with serialization.";
public const string Xml_CanNotDeserializeObjectType = @"Unable to proceed with deserialization. Data does not implement IXMLSerializable, therefore polymorphism is not supported.";
public const string Xml_DataTableInferenceNotSupported = @"DataTable does not support schema inference from Xml.";
public const string Xml_MultipleParentRows = @"Cannot proceed with serializing DataTable '{0}'. It contains a DataRow which has multiple parent rows on the same Foreign Key.";
public const string Xml_IsDataSetAttributeMissingInSchema = @"IsDataSet attribute is missing in input Schema.";
public const string Xml_TooManyIsDataSetAtributeInSchema = @"Cannot determine the DataSet Element. IsDataSet attribute exist more than once.";
public const string Xml_DynamicWithoutXmlSerializable = @"DataSet will not serialize types that implement IDynamicMetaObjectProvider but do not also implement IXmlSerializable.";



public const string Expr_NYI = @"The feature not implemented. {0}.";
public const string Expr_MissingOperand = @"Syntax error: Missing operand after '{0}' operator.";
public const string Expr_TypeMismatch = @"Type mismatch in expression '{0}'.";
public const string Expr_ExpressionTooComplex = @"Expression is too complex.";
public const string Expr_UnboundName = @"Cannot find column [{0}].";
public const string Expr_InvalidString = @"The expression contains an invalid string constant: {0}.";
public const string Expr_UndefinedFunction = @"The expression contains undefined function call {0}().";
public const string Expr_Syntax = @"Syntax error in the expression.";
public const string Expr_FunctionArgumentCount = @"Invalid number of arguments: function {0}().";
public const string Expr_MissingRightParen = @"The expression is missing the closing parenthesis.";
public const string Expr_UnknownToken = @"Cannot interpret token '{0}' at position {1}.";
public const string Expr_UnknownToken1 = @"Expected {0}, but actual token at the position {2} is {1}.";
public const string Expr_DatatypeConvertion = @"Cannot convert from {0} to {1}.";
public const string Expr_DatavalueConvertion = @"Cannot convert value '{0}' to Type: {1}.";
public const string Expr_InvalidName = @"Invalid column name [{0}].";
public const string Expr_InvalidDate = @"The expression contains invalid date constant '{0}'.";
public const string Expr_NonConstantArgument = @"Only constant expressions are allowed in the expression list for the IN operator.";
public const string Expr_InvalidPattern = @"Error in Like operator: the string pattern '{0}' is invalid.";
public const string Expr_InWithoutParentheses = @"Syntax error: The items following the IN keyword must be separated by commas and be enclosed in parentheses.";
public const string Expr_ArgumentType = @"Type mismatch in function argument: {0}(), argument {1}, expected {2}.";
public const string Expr_ArgumentTypeInteger = @"Type mismatch in function argument: {0}(), argument {1}, expected one of the Integer types.";
public const string Expr_TypeMismatchInBinop = @"Cannot perform '{0}' operation on {1} and {2}.";
public const string Expr_AmbiguousBinop = @"Operator '{0}' is ambiguous on operands of type '{1}' and '{2}'. Cannot mix signed and unsigned types. Please use explicit Convert() function.";
public const string Expr_InWithoutList = @"Syntax error: The IN keyword must be followed by a non-empty list of expressions separated by commas, and also must be enclosed in parentheses.";
public const string Expr_UnsupportedOperator = @"The expression contains unsupported operator '{0}'.";
public const string Expr_InvalidNameBracketing = @"The expression contains invalid name: '{0}'.";
public const string Expr_MissingOperandBefore = @"Syntax error: Missing operand before '{0}' operator.";
public const string Expr_TooManyRightParentheses = @"The expression has too many closing parentheses.";
public const string Expr_UnresolvedRelation = @"The table [{0}] involved in more than one relation. You must explicitly mention a relation name in the expression '{1}'.";
public const string Expr_AggregateArgument = @"Syntax error in aggregate argument: Expecting a single column argument with possible 'Child' qualifier.";
public const string Expr_AggregateUnbound = @"Unbound reference in the aggregate expression '{0}'.";
public const string Expr_EvalNoContext = @"Cannot evaluate non-constant expression without current row.";
public const string Expr_ExpressionUnbound = @"Unbound reference in the expression '{0}'.";
public const string Expr_ComputeNotAggregate = @"Cannot evaluate. Expression '{0}' is not an aggregate.";
public const string Expr_FilterConvertion = @"Filter expression '{0}' does not evaluate to a Boolean term.";
public const string Expr_InvalidType = @"Invalid type name '{0}'.";
public const string Expr_LookupArgument = @"Syntax error in Lookup expression: Expecting keyword 'Parent' followed by a single column argument with possible relation qualifier: Parent[(<relation_name>)].<column_name>.";
public const string Expr_InvokeArgument = @"Need a row or a table to Invoke DataFilter.";
public const string Expr_ArgumentOutofRange = @"{0}() argument is out of range.";
public const string Expr_IsSyntax = @"Syntax error: Invalid usage of 'Is' operator. Correct syntax: <expression> Is [Not] Null.";
public const string Expr_Overflow = @"Value is either too large or too small for Type '{0}'.";
public const string Expr_DivideByZero = @"Divide by zero error encountered.";
public const string Expr_BindFailure = @"Cannot find the parent relation '{0}'.";
public const string Expr_InvalidHoursArgument = @"'hours' argument is out of range. Value must be between -14 and +14.";
public const string Expr_InvalidMinutesArgument = @"'minutes' argument is out of range. Value must be between -59 and +59.";
public const string Expr_InvalidTimeZoneRange = @"Provided range for time one exceeds total of 14 hours.";
public const string Expr_MismatchKindandTimeSpan = @"Kind property of provided DateTime argument, does not match 'hours' and 'minutes' arguments.";
public const string Expr_UnsupportedType = @"A DataColumn of type '{0}' does not support expression.";




public const string Data_EnforceConstraints = @"Failed to enable constraints. One or more rows contain values violating non-null, unique, or foreign-key constraints.";
public const string Data_CannotModifyCollection = @"Collection itself is not modifiable.";
public const string Data_CaseInsensitiveNameConflict = @"The given name '{0}' matches at least two names in the collection object with different cases, but does not match either of them with the same case.";
public const string Data_NamespaceNameConflict = @"The given name '{0}' matches at least two names in the collection object with different namespaces.";
public const string Data_InvalidOffsetLength = @"Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.";

public const string Data_ArgumentOutOfRange = @"'{0}' argument is out of range.";
public const string Data_ArgumentNull = @"'{0}' argument cannot be null.";
public const string Data_ArgumentContainsNull = @"'{0}' argument contains null value.";

public const string DataColumns_OutOfRange = @"Cannot find column {0}.";
public const string DataColumns_Add1 = @"Column '{0}' already belongs to this DataTable.";
public const string DataColumns_Add2 = @"Column '{0}' already belongs to another DataTable.";
public const string DataColumns_Add3 = @"Cannot have more than one SimpleContent columns in a DataTable.";
public const string DataColumns_Add4 = @"Cannot add a SimpleContent column to a table containing element columns or nested relations.";
public const string DataColumns_AddDuplicate = @"A column named '{0}' already belongs to this DataTable.";
public const string DataColumns_AddDuplicate2 = @"Cannot add a column named '{0}': a nested table with the same name already belongs to this DataTable.";
public const string DataColumns_AddDuplicate3 = @"A column named '{0}' already belongs to this DataTable: cannot set a nested table name to the same name.";
public const string DataColumns_Remove = @"Cannot remove a column that doesn't belong to this table.";
public const string DataColumns_RemovePrimaryKey = @"Cannot remove this column, because it's part of the primary key.";
public const string DataColumns_RemoveChildKey = @"Cannot remove this column, because it is part of the parent key for relationship {0}.";
public const string DataColumns_RemoveConstraint = @"Cannot remove this column, because it is a part of the constraint {0} on the table {1}.";
public const string DataColumns_RemoveExpression = @"Cannot remove this column, because it is part of an expression: {0} = {1}.";

public const string DataColumn_AutoIncrementAndExpression = @"Cannot set AutoIncrement property for a computed column.";
public const string DataColumn_AutoIncrementAndDefaultValue = @"Cannot set AutoIncrement property for a column with DefaultValue set.";
public const string DataColumn_DefaultValueAndAutoIncrement = @"Cannot set a DefaultValue on an AutoIncrement column.";
public const string DataColumn_AutoIncrementSeed = @"AutoIncrementStep must be a non-zero value.";
public const string DataColumn_NameRequired = @"ColumnName is required when it is part of a DataTable.";
public const string DataColumn_ChangeDataType = @"Cannot change DataType of a column once it has data.";
public const string DataColumn_NullDataType = @"Column requires a valid DataType.";
public const string DataColumn_DefaultValueDataType = @"The DefaultValue for column {0} is of type {1} and cannot be converted to {2}.";
public const string DataColumn_DefaultValueDataType1 = @"The DefaultValue for the column is of type {0} and cannot be converted to {1}.";
public const string DataColumn_DefaultValueColumnDataType = @"The DefaultValue for column {0} is of type {1}, but the column is of type {2}.";
public const string DataColumn_ReadOnlyAndExpression = @"Cannot change ReadOnly property for the expression column.";
public const string DataColumn_UniqueAndExpression = @"Cannot change Unique property for the expression column.";
public const string DataColumn_ExpressionAndUnique = @"Cannot create an expression on a column that has AutoIncrement or Unique.";
public const string DataColumn_ExpressionAndReadOnly = @"Cannot set expression because column cannot be made ReadOnly.";
public const string DataColumn_ExpressionAndConstraint = @"Cannot set Expression property on column {0}, because it is a part of a constraint.";
public const string DataColumn_ExpressionInConstraint = @"Cannot create a constraint based on Expression column {0}.";
public const string DataColumn_ExpressionCircular = @"Cannot set Expression property due to circular reference in the expression.";
public const string DataColumn_NullKeyValues = @"Column '{0}' has null values in it.";
public const string DataColumn_NullValues = @"Column '{0}' does not allow nulls.";
public const string DataColumn_ReadOnly = @"Column '{0}' is read only.";
public const string DataColumn_NonUniqueValues = @"Column '{0}' contains non-unique values.";
public const string DataColumn_NotInTheTable = @"Column '{0}' does not belong to table {1}.";
public const string DataColumn_NotInAnyTable = @"Column must belong to a table.";
public const string DataColumn_SetFailed = @"Couldn't store <{0}> in {1} Column.  Expected type is {2}.";
public const string DataColumn_CannotSetToNull = @"Cannot set Column '{0}' to be null. Please use DBNull instead.";
public const string DataColumn_LongerThanMaxLength = @"Cannot set column '{0}'. The value violates the MaxLength limit of this column.";
public const string DataColumn_HasToBeStringType = @"MaxLength applies to string data type only. You cannot set Column '{0}' property MaxLength to be non-negative number.";
public const string DataColumn_CannotSetMaxLength = @"Cannot set Column '{0}' property MaxLength to '{1}'. There is at least one string in the table longer than the new limit.";
public const string DataColumn_CannotSetMaxLength2 = @"Cannot set Column '{0}' property MaxLength. The Column is SimpleContent.";
public const string DataColumn_CannotSimpleContentType = @"Cannot set Column '{0}' property DataType to {1}. The Column is SimpleContent.";
public const string DataColumn_CannotSimpleContent = @"Cannot set Column '{0}' property MappingType to SimpleContent. The Column DataType is {1}.";
public const string DataColumn_ExceedMaxLength = @"Column '{0}' exceeds the MaxLength limit.";
public const string DataColumn_NotAllowDBNull = @"Column '{0}' does not allow DBNull.Value.";
public const string DataColumn_CannotChangeNamespace = @"Cannot change the Column '{0}' property Namespace. The Column is SimpleContent.";
public const string DataColumn_AutoIncrementCannotSetIfHasData = @"Cannot change AutoIncrement of a DataColumn with type '{0}' once it has data.";
public const string DataColumn_NotInTheUnderlyingTable = @"Column '{0}' does not belong to underlying table '{1}'.";
public const string DataColumn_InvalidDataColumnMapping = @"DataColumn with type '{0}' is a complexType. Can not serialize value of a complex type as Attribute";
public const string DataColumn_CannotSetDateTimeModeForNonDateTimeColumns = @"The DateTimeMode can be set only on DataColumns of type DateTime.";
public const string DataColumn_InvalidDateTimeMode = @"'{0}' is Invalid DataSetDateTime value.";
public const string DataColumn_DateTimeMode = @"Cannot change DateTimeMode from '{0}' to '{1}' once the table has data.";
public const string DataColumn_INullableUDTwithoutStaticNull = @"Type '{0}' does not contain static Null property or field.";
public const string DataColumn_UDTImplementsIChangeTrackingButnotIRevertible = @"Type '{0}' does not implement IRevertibleChangeTracking; therefore can not proceed with RejectChanges().";
public const string DataColumn_SetAddedAndModifiedCalledOnNonUnchanged = @"SetAdded and SetModified can only be called on DataRows with Unchanged DataRowState.";
public const string DataColumn_OrdinalExceedMaximun = @"Ordinal '{0}' exceeds the maximum number.";
public const string DataColumn_NullableTypesNotSupported = @"DataSet does not support System.Nullable<>.";

public const string DataConstraint_NoName = @"Cannot change the name of a constraint to empty string when it is in the ConstraintCollection.";
public const string DataConstraint_Violation = @"Cannot enforce constraints on constraint {0}.";
public const string DataConstraint_ViolationValue = @"Column '{0}' is constrained to be unique.  Value '{1}' is already present.";
public const string DataConstraint_NotInTheTable = @"Constraint '{0}' does not belong to this DataTable.";
public const string DataConstraint_OutOfRange = @"Cannot find constraint {0}.";
public const string DataConstraint_Duplicate = @"Constraint matches constraint named {0} already in collection.";
public const string DataConstraint_DuplicateName = @"A Constraint named '{0}' already belongs to this DataTable.";
public const string DataConstraint_UniqueViolation = @"These columns don't currently have unique values.";
public const string DataConstraint_ForeignTable = @"These columns don't point to this table.";
public const string DataConstraint_ParentValues = @"This constraint cannot be enabled as not all values have corresponding parent values.";
public const string DataConstraint_AddFailed = @"This constraint cannot be added since ForeignKey doesn't belong to table {0}.";
public const string DataConstraint_RemoveFailed = @"Cannot remove a constraint that doesn't belong to this table.";
public const string DataConstraint_NeededForForeignKeyConstraint = @"Cannot remove unique constraint '{0}'. Remove foreign key constraint '{1}' first.";
public const string DataConstraint_CascadeDelete = @"Cannot delete this row because constraints are enforced on relation {0}, and deleting this row will strand child rows.";
public const string DataConstraint_CascadeUpdate = @"Cannot make this change because constraints are enforced on relation {0}, and changing this value will strand child rows.";
public const string DataConstraint_ClearParentTable = @"Cannot clear table {0} because ForeignKeyConstraint {1} enforces constraints and there are child rows in {2}.";
public const string DataConstraint_ForeignKeyViolation = @"ForeignKeyConstraint {0} requires the child key values ({1}) to exist in the parent table.";
public const string DataConstraint_BadObjectPropertyAccess = @"Property not accessible because '{0}'.";
public const string DataConstraint_RemoveParentRow = @"Cannot remove this row because it has child rows, and constraints on relation {0} are enforced.";
public const string DataConstraint_AddPrimaryKeyConstraint = @"Cannot add primary key constraint since primary key is already set for the table.";
public const string DataConstraint_CantAddConstraintToMultipleNestedTable = @"Cannot add constraint to DataTable '{0}' which is a child table in two nested relations.";

public const string DataKey_TableMismatch = @"Cannot create a Key from Columns that belong to different tables.";
public const string DataKey_NoColumns = @"Cannot have 0 columns.";
public const string DataKey_TooManyColumns = @"Cannot have more than {0} columns.";
public const string DataKey_DuplicateColumns = @"Cannot create a Key when the same column is listed more than once: '{0}'";
public const string DataKey_RemovePrimaryKey = @"Cannot remove unique constraint since it's the primary key of a table.";
public const string DataKey_RemovePrimaryKey1 = @"Cannot remove unique constraint since it's the primary key of table {0}.";

public const string DataRelation_ColumnsTypeMismatch = @"Parent Columns and Child Columns don't have type-matching columns.";
public const string DataRelation_KeyColumnsIdentical = @"ParentKey and ChildKey are identical.";
public const string DataRelation_KeyLengthMismatch = @"ParentColumns and ChildColumns should be the same length.";
public const string DataRelation_KeyZeroLength = @"ParentColumns and ChildColumns must not be zero length.";
public const string DataRelation_ForeignRow = @"The row doesn't belong to the same DataSet as this relation.";
public const string DataRelation_NoName = @"RelationName is required when it is part of a DataSet.";
public const string DataRelation_ForeignTable = @"GetChildRows requires a row whose Table is {0}, but the specified row's Table is {1}.";
public const string DataRelation_ForeignDataSet = @"This relation should connect two tables in this DataSet to be added to this DataSet.";
public const string DataRelation_GetParentRowTableMismatch = @"GetParentRow requires a row whose Table is {0}, but the specified row's Table is {1}.";
public const string DataRelation_SetParentRowTableMismatch = @"SetParentRow requires a child row whose Table is {0}, but the specified row's Table is {1}.";
public const string DataRelation_DataSetMismatch = @"Cannot have a relationship between tables in different DataSets.";
public const string DataRelation_TablesInDifferentSets = @"Cannot create a relation between tables in different DataSets.";
public const string DataRelation_AlreadyExists = @"A relation already exists for these child columns.";
public const string DataRelation_DoesNotExist = @"This relation doesn't belong to this relation collection.";
public const string DataRelation_AlreadyInOtherDataSet = @"This relation already belongs to another DataSet.";
public const string DataRelation_AlreadyInTheDataSet = @"This relation already belongs to this DataSet.";
public const string DataRelation_DuplicateName = @"A Relation named '{0}' already belongs to this DataSet.";
public const string DataRelation_NotInTheDataSet = @"Relation {0} does not belong to this DataSet.";
public const string DataRelation_OutOfRange = @"Cannot find relation {0}.";
public const string DataRelation_TableNull = @"Cannot create a collection on a null table.";
public const string DataRelation_TableWasRemoved = @"The table this collection displays relations for has been removed from its DataSet.";
public const string DataRelation_ChildTableMismatch = @"Cannot add a relation to this table's ParentRelation collection where this table isn't the child table.";
public const string DataRelation_ParentTableMismatch = @"Cannot add a relation to this table's ChildRelation collection where this table isn't the parent table.";
public const string DataRelation_RelationNestedReadOnly = @"Cannot set the 'Nested' property to false for this relation.";
public const string DataRelation_TableCantBeNestedInTwoTables = @"The same table '{0}' cannot be the child table in two nested relations.";
public const string DataRelation_LoopInNestedRelations = @"The table ({0}) cannot be the child table to itself in nested relations.";
public const string DataRelation_CaseLocaleMismatch = @"Cannot add a DataRelation or Constraint that has different Locale or CaseSensitive settings between its parent and child tables.";
public const string DataRelation_ParentOrChildColumnsDoNotHaveDataSet = @"Cannot create a DataRelation if Parent or Child Columns are not in a DataSet.";
public const string DataRelation_InValidNestedRelation = @"Nested table '{0}' which inherits its namespace cannot have multiple parent tables in different namespaces.";
public const string DataRelation_InValidNamespaceInNestedRelation = @"Nested table '{0}' with empty namespace cannot have multiple parent tables in different namespaces.";

public const string DataRow_NotInTheDataSet = @"The row doesn't belong to the same DataSet as this relation.";
public const string DataRow_NotInTheTable = @"Cannot perform this operation on a row not in the table.";
public const string DataRow_ParentRowNotInTheDataSet = @"This relation and child row don't belong to same DataSet.";
public const string DataRow_EditInRowChanging = @"Cannot change a proposed value in the RowChanging event.";
public const string DataRow_EndEditInRowChanging = @"Cannot call EndEdit() inside an OnRowChanging event.";
public const string DataRow_BeginEditInRowChanging = @"Cannot call BeginEdit() inside the RowChanging event.";
public const string DataRow_CancelEditInRowChanging = @"Cannot call CancelEdit() inside an OnRowChanging event.  Throw an exception to cancel this update.";
public const string DataRow_DeleteInRowDeleting = @"Cannot call Delete inside an OnRowDeleting event.  Throw an exception to cancel this delete.";
public const string DataRow_ValuesArrayLength = @"Input array is longer than the number of columns in this table.";
public const string DataRow_NoCurrentData = @"There is no Current data to access.";
public const string DataRow_NoOriginalData = @"There is no Original data to access.";
public const string DataRow_NoProposedData = @"There is no Proposed data to access.";
public const string DataRow_RemovedFromTheTable = @"This row has been removed from a table and does not have any data.  BeginEdit() will allow creation of new data in this row.";
public const string DataRow_DeletedRowInaccessible = @"Deleted row information cannot be accessed through the row.";
public const string DataRow_InvalidVersion = @"Version must be Original, Current, or Proposed.";
public const string DataRow_OutOfRange = @"There is no row at position {0}.";
public const string DataRow_RowInsertOutOfRange = @"The row insert position {0} is invalid.";
public const string DataRow_RowInsertTwice = @"The rowOrder value={0} has been found twice for table named '{1}'.";
public const string DataRow_RowInsertMissing = @"Values are missing in the rowOrder sequence for table '{0}'.";
public const string DataRow_RowOutOfRange = @"The given DataRow is not in the current DataRowCollection.";
public const string DataRow_AlreadyInOtherCollection = @"This row already belongs to another table.";
public const string DataRow_AlreadyInTheCollection = @"This row already belongs to this table.";
public const string DataRow_AlreadyDeleted = @"Cannot delete this row since it's already deleted.";
public const string DataRow_Empty = @"This row is empty.";
public const string DataRow_AlreadyRemoved = @"Cannot remove a row that's already been removed.";
public const string DataRow_MultipleParents = @"A child row has multiple parents.";
public const string DataRow_InvalidRowBitPattern = @"Unrecognized row state bit pattern.";

public const string DataSet_SetNameToEmpty = @"Cannot change the name of the DataSet to an empty string.";
public const string DataSet_SetDataSetNameConflicting = @"The name '{0}' is invalid. A DataSet cannot have the same name of the DataTable.";
public const string DataSet_UnsupportedSchema = @"The schema namespace is invalid. Please use this one instead: {0}.";
public const string DataSet_CannotChangeCaseLocale = @"Cannot change CaseSensitive or Locale property. This change would lead to at least one DataRelation or Constraint to have different Locale or CaseSensitive settings between its related tables.";
public const string DataSet_CannotChangeSchemaSerializationMode = @"SchemaSerializationMode property can be set only if it is overridden by derived DataSet.";

public const string DataTable_ForeignPrimaryKey = @"PrimaryKey columns do not belong to this table.";
public const string DataTable_CannotAddToSimpleContent = @"Cannot add a nested relation or an element column to a table containing a SimpleContent column.";
public const string DataTable_NoName = @"TableName is required when it is part of a DataSet.";
public const string DataTable_MultipleSimpleContentColumns = @"DataTable already has a simple content column.";
public const string DataTable_MissingPrimaryKey = @"Table doesn't have a primary key.";
public const string DataTable_InvalidSortString = @" {0} isn't a valid Sort string entry.";
public const string DataTable_CanNotSerializeDataTableHierarchy = @"Cannot serialize the DataTable. A DataTable being used in one or more DataColumn expressions is not a descendant of current DataTable.";
public const string DataTable_CanNotRemoteDataTable = @"This DataTable can only be remoted as part of DataSet. One or more Expression Columns has reference to other DataTable(s).";
public const string DataTable_CanNotSetRemotingFormat = @"Cannot have different remoting format property value for DataSet and DataTable.";
public const string DataTable_CanNotSerializeDataTableWithEmptyName = @"Cannot serialize the DataTable. DataTable name is not set.";

public const string DataTable_DuplicateName = @"A DataTable named '{0}' already belongs to this DataSet.";
public const string DataTable_DuplicateName2 = @"A DataTable named '{0}' with the same Namespace '{1}' already belongs to this DataSet.";
public const string DataTable_SelfnestedDatasetConflictingName = @"The table ({0}) cannot be the child table to itself in a nested relation: the DataSet name conflicts with the table name.";
public const string DataTable_DatasetConflictingName = @"The name '{0}' is invalid. A DataTable cannot have the same name of the DataSet.";
public const string DataTable_AlreadyInOtherDataSet = @"DataTable already belongs to another DataSet.";
public const string DataTable_AlreadyInTheDataSet = @"DataTable already belongs to this DataSet.";
public const string DataTable_NotInTheDataSet = @"Table {0} does not belong to this DataSet.";
public const string DataTable_OutOfRange = @"Cannot find table {0}.";
public const string DataTable_InRelation = @"Cannot remove a table that has existing relations.  Remove relations first.";
public const string DataTable_InConstraint = @"Cannot remove table {0}, because it referenced in ForeignKeyConstraint {1}.  Remove the constraint first.";
public const string DataTable_TableNotFound = @"DataTable '{0}' does not match to any DataTable in source.";

public const string DataMerge_MissingDefinition = @"Target DataSet missing definition for {0}.";
public const string DataMerge_MissingConstraint = @"Target DataSet missing {0} {1}.";
public const string DataMerge_DataTypeMismatch = @"<target>.{0} and <source>.{0} have conflicting properties: DataType property mismatch.";
public const string DataMerge_PrimaryKeyMismatch = @"<target>.PrimaryKey and <source>.PrimaryKey have different Length.";
public const string DataMerge_PrimaryKeyColumnsMismatch = @"Mismatch columns in the PrimaryKey : <target>.{0} versus <source>.{1}.";
public const string DataMerge_ReltionKeyColumnsMismatch = @"Relation {0} cannot be merged, because keys have mismatch columns.";
public const string DataMerge_MissingColumnDefinition = @"Target table {0} missing definition for column {1}.";
public const string DataMerge_MissingPrimaryKeyColumnInSource = @"PrimaryKey column {0} does not exist in source Table.";

public const string DataIndex_RecordStateRange = @"The RowStates parameter must be set to a valid combination of values from the DataViewRowState enumeration.";
public const string DataIndex_FindWithoutSortOrder = @"Find finds a row based on a Sort order, and no Sort order is specified.";
public const string DataIndex_KeyLength = @"Expecting {0} value(s) for the key being indexed, but received {1} value(s).";

public const string DataStorage_AggregateException = @"Invalid usage of aggregate function {0}() and Type: {1}.";
public const string DataStorage_InvalidStorageType = @"Invalid storage type: {0}.";
public const string DataStorage_ProblematicChars = @"The DataSet Xml persistency does not support the value '{0}' as Char value, please use Byte storage instead.";
public const string DataStorage_SetInvalidDataType = @"Type of value has a mismatch with column type";
public const string DataStorage_IComparableNotDefined = @" Type '{0}' does not implement IComparable interface. Comparison cannot be done.";

public const string DataView_SetFailed = @"Cannot set {0}.";
public const string DataView_SetDataSetFailed = @"Cannot change DataSet on a DataViewManager that's already the default view for a DataSet.";
public const string DataView_SetRowStateFilter = @"RowStateFilter cannot show ModifiedOriginals and ModifiedCurrents at the same time.";
public const string DataView_SetTable = @"Cannot change Table property on a DefaultView or a DataView coming from a DataViewManager.";
public const string DataView_CanNotSetDataSet = @"Cannot change DataSet property once it is set.";
public const string DataView_CanNotUseDataViewManager = @"DataSet must be set prior to using DataViewManager.";
public const string DataView_CanNotSetTable = @"Cannot change Table property once it is set.";
public const string DataView_CanNotUse = @"DataTable must be set prior to using DataView.";
public const string DataView_CanNotBindTable = @"Cannot bind to DataTable with no name.";
public const string DataView_SetIListObject = @"Cannot set an object into this list.";
public const string DataView_AddNewNotAllowNull = @"Cannot call AddNew on a DataView where AllowNew is false.";
public const string DataView_NotOpen = @"DataView is not open.";
public const string DataView_CreateChildView = @"The relation is not parented to the table to which this DataView points.";
public const string DataView_CanNotDelete = @"Cannot delete on a DataSource where AllowDelete is false.";
public const string DataView_CanNotEdit = @"Cannot edit on a DataSource where AllowEdit is false.";
public const string DataView_GetElementIndex = @"Index {0} is either negative or above rows count.";
public const string DataView_AddExternalObject = @"Cannot add external objects to this list.";
public const string DataView_CanNotClear = @"Cannot clear this list.";
public const string DataView_InsertExternalObject = @"Cannot insert external objects to this list.";
public const string DataView_RemoveExternalObject = @"Cannot remove objects not in the list.";

public const string DataROWView_PropertyNotFound = @"{0} is neither a DataColumn nor a DataRelation for table {1}.";

public const string Range_Argument = @"Min ({0}) must be less than or equal to max ({1}) in a Range object.";
public const string Range_NullRange = @"This is a null range.";
public const string RecordManager_MinimumCapacity = @"MinimumCapacity must be non-negative.";


public const string CodeGen_InvalidIdentifier = @"Cannot generate identifier for name '{0}'.";
public const string CodeGen_DuplicateTableName = @"There is more than one table with the same name '{0}' (even if namespace is different).";
public const string CodeGen_TypeCantBeNull = @"Column '{0}': Type '{1}' cannot be null.";
public const string CodeGen_NoCtor0 = @"Column '{0}': Type '{1}' does not have parameterless constructor.";
public const string CodeGen_NoCtor1 = @"Column '{0}': Type '{1}' does not have constructor with string argument.";



public const string SqlConvert_ConvertFailed = @" Cannot convert object of type '{0}' to object of type '{1}'.";


public const string DataSet_DefaultDataException = @"Data Exception.";
public const string DataSet_DefaultConstraintException = @"Constraint Exception.";
public const string DataSet_DefaultDeletedRowInaccessibleException = @"Deleted rows inaccessible.";
public const string DataSet_DefaultDuplicateNameException = @"Duplicate name not allowed.";
public const string DataSet_DefaultInRowChangingEventException = @"Operation not supported in the RowChanging event.";
public const string DataSet_DefaultInvalidConstraintException = @"Invalid constraint.";
public const string DataSet_DefaultMissingPrimaryKeyException = @"Missing primary key.";
public const string DataSet_DefaultNoNullAllowedException = @"Null not allowed.";
public const string DataSet_DefaultReadOnlyException = @"Column is marked read only.";
public const string DataSet_DefaultRowNotInTableException = @"Row not found in table.";
public const string DataSet_DefaultVersionNotFoundException = @"Version not found.";


public const string Load_ReadOnlyDataModified = @"ReadOnly Data is Modified.";



public const string DataTableReader_InvalidDataTableReader = @"DataTableReader is invalid for current DataTable '{0}'.";
public const string DataTableReader_SchemaInvalidDataTableReader = @"Schema of current DataTable '{0}' in DataTableReader has changed, DataTableReader is invalid.";
public const string DataTableReader_CannotCreateDataReaderOnEmptyDataSet = @"DataTableReader Cannot be created. There is no DataTable in DataSet.";
public const string DataTableReader_DataTableReaderArgumentIsEmpty = @"Cannot create DataTableReader. Argument is Empty.";
public const string DataTableReader_ArgumentContainsNullValue = @"Cannot create DataTableReader. Arguments contain null value.";
public const string DataTableReader_InvalidRowInDataTableReader = @"Current DataRow is either in Deleted or Detached state.";

public const string DataTableReader_DataTableCleared = @"Current DataTable '{0}' is empty. There is no DataRow in DataTable.";




public const string RbTree_InvalidState = @"DataTable internal index is corrupted: '{0}'.";
public const string RbTree_EnumerationBroken = @"Collection was modified; enumeration operation might not execute.";


public const string NamedSimpleType_InvalidDuplicateNamedSimpleTypeDelaration = @"Simple type '{0}' has already be declared with different '{1}'.";



public const string DataDom_Foliation = @"Invalid foliation.";
public const string DataDom_TableNameChange = @"Cannot change the table name once the associated DataSet is mapped to a loaded XML document.";
public const string DataDom_TableNamespaceChange = @"Cannot change the table namespace once the associated DataSet is mapped to a loaded XML document.";
public const string DataDom_ColumnNameChange = @"Cannot change the column name once the associated DataSet is mapped to a loaded XML document.";
public const string DataDom_ColumnNamespaceChange = @"Cannot change the column namespace once the associated DataSet is mapped to a loaded XML document.";
public const string DataDom_ColumnMappingChange = @"Cannot change the ColumnMapping property once the associated DataSet is mapped to a loaded XML document.";
public const string DataDom_TableColumnsChange = @"Cannot add or remove columns from the table once the DataSet is mapped to a loaded XML document.";
public const string DataDom_DataSetTablesChange = @"Cannot add or remove tables from the DataSet once the DataSet is mapped to a loaded XML document.";
public const string DataDom_DataSetNestedRelationsChange = @"Cannot add, remove, or change Nested relations from the DataSet once the DataSet is mapped to a loaded XML document.";
public const string DataDom_DataSetNull = @"The DataSet parameter is invalid. It cannot be null.";
public const string DataDom_DataSetNameChange = @"Cannot change the DataSet name once the DataSet is mapped to a loaded XML document.";
public const string DataDom_CloneNode = @"This type of node cannot be cloned: {0}.";
public const string DataDom_MultipleLoad = @"Cannot load XmlDataDocument if it already contains data. Please use a new XmlDataDocument.";
public const string DataDom_MultipleDataSet = @"DataSet can be associated with at most one XmlDataDocument. Cannot associate the DataSet with the current XmlDataDocument because the DataSet is already associated with another XmlDataDocument.";
public const string DataDom_EnforceConstraintsShouldBeOff = @"Please set DataSet.EnforceConstraints == false before trying to edit XmlDataDocument using XML operations.";
public const string DataDom_NotSupport_GetElementById = @"GetElementById() is not supported on DataDocument.";
public const string DataDom_NotSupport_EntRef = @"Cannot create entity references on DataDocument.";
public const string DataDom_NotSupport_Clear = @"Clear function on DateSet and DataTable is not supported on XmlDataDocument.";




public const string StrongTyping_CannotRemoveColumn = @"Cannot remove column since it is built in to this dataSet.";
public const string StrongTyping_CananotRemoveRelation = @"Cannot remove relation since it is built in to this dataSet.";
public const string propertyChangedEventDescr = @"Occurs whenever a property for this control changes.";
public const string collectionChangedEventDescr = @"Occurs whenever this collection's membership changes.";
public const string StrongTyping_CananotAccessDBNull = @"Cannot get value because it is DBNull.";






public const string ADP_PropertyNotSupported = @"The '{0}' property requires Microsoft WindowsNT or a WindowsNT based operating system.";


public const string ConfigProviderNotFound = @"Unable to find the requested .Net Framework Data Provider.  It may not be installed.";
public const string ConfigProviderInvalid = @"The requested .Net Framework Data Provider's implementation does not have an Instance field of a System.Data.Common.DbProviderFactory derived type.";
public const string ConfigProviderNotInstalled = @"Failed to find or load the registered .Net Framework Data Provider.";
public const string ConfigProviderMissing = @"The missing .Net Framework Data Provider's assembly qualified name is required.";


public const string ConfigBaseElementsOnly = @"Only elements allowed.";
public const string ConfigBaseNoChildNodes = @"Child nodes not allowed.";
public const string ConfigUnrecognizedAttributes = @"Unrecognized attribute '{0}'.";
public const string ConfigUnrecognizedElement = @"Unrecognized element.";
public const string ConfigSectionsUnique = @"The '{0}' section can only appear once per config file.";
public const string ConfigRequiredAttributeMissing = @"Required attribute '{0}' not found.";
public const string ConfigRequiredAttributeEmpty = @"Required attribute '{0}' cannot be empty.";

public const string ADP_EmptyArray = @"Expecting non-empty array for '{0}' parameter.";


public const string ADP_SingleValuedProperty = @"The only acceptable value for the property '{0}' is '{1}'.";
public const string ADP_DoubleValuedProperty = @"The acceptable values for the property '{0}' are '{1}' or '{2}'.";
public const string ADP_InvalidPrefixSuffix = @"Specified QuotePrefix and QuoteSuffix values do not match.";

public const string ADP_InvalidArgumentLength = @"The length of argument '{0}' exceeds it's limit of '{1}'.";





public const string SQL_WrongType = @"Expecting argument of type {1}, but received type {0}.";



public const string ADP_InvalidConnectionOptionValue = @"Invalid value for key '{0}'.";
public const string ADP_MissingConnectionOptionValue = @"Use of key '{0}' requires the key '{1}' to be present.";
public const string ADP_InvalidConnectionOptionValueLength = @"The value's length for key '{0}' exceeds it's limit of '{1}'.";


public const string ADP_KeywordNotSupported = @"Keyword not supported: '{0}'.";


public const string ADP_UdlFileError = @"Unable to load the UDL file.";
public const string ADP_InvalidUDL = @"Invalid UDL file.";





public const string ADP_InternalProviderError = @"Internal .Net Framework Data Provider error {0}.";










public const string ADP_NoQuoteChange = @"The QuotePrefix and QuoteSuffix properties cannot be changed once an Insert, Update, or Delete command has been generated.";
public const string ADP_MissingSourceCommand = @"The DataAdapter.SelectCommand property needs to be initialized.";
public const string ADP_MissingSourceCommandConnection = @"The DataAdapter.SelectCommand.Connection property needs to be initialized;";


public const string ADP_InvalidMultipartName = @"{0} ""{1}"".";
public const string ADP_InvalidMultipartNameQuoteUsage = @"{0} ""{1}"", incorrect usage of quotes.";
public const string ADP_InvalidMultipartNameToManyParts = @"{0} ""{1}"", the current limit of ""{2}"" is insufficient.";


public const string SQL_BulkCopyDestinationTableName = @"SqlBulkCopy.WriteToServer failed because the SqlBulkCopy.DestinationTableName is an invalid multipart name";
public const string SQL_TDSParserTableName = @"Processing of results from SQL Server failed because of an invalid multipart name";
public const string SQL_UDTTypeName = @"SqlParameter.UdtTypeName is an invalid multipart name";
public const string SQL_TypeName = @"SqlParameter.TypeName is an invalid multipart name";
public const string SQL_SqlCommandCommandText = @"SqlCommand.DeriveParameters failed because the SqlCommand.CommandText property value is an invalid multipart name";
public const string ODBC_ODBCCommandText = @"OdbcCommandBuilder.DeriveParameters failed because the OdbcCommand.CommandText property value is an invalid multipart name";
public const string OLEDB_OLEDBCommandText = @"OleDbCommandBuilder.DeriveParameters failed because the OleDbCommandBuilder.CommandText property value is an invalid multipart name";


public const string SQLMSF_FailoverPartnerNotSupported = @"Connecting to a mirrored SQL Server instance using the MultiSubnetFailover connection option is not supported.";













public const string ADP_ColumnSchemaExpression = @"The column mapping from SourceColumn '{0}' failed because the DataColumn '{1}' is a computed column.";
public const string ADP_ColumnSchemaMismatch = @"Inconvertible type mismatch between SourceColumn '{0}' of {1} and the DataColumn '{2}' of {3}.";
public const string ADP_ColumnSchemaMissing1 = @"Missing the DataColumn '{0}' for the SourceColumn '{2}'.";
public const string ADP_ColumnSchemaMissing2 = @"Missing the DataColumn '{0}' in the DataTable '{1}' for the SourceColumn '{2}'.";



public const string ADP_InvalidSourceColumn = @"SourceColumn is required to be a non-empty string.";

public const string ADP_MissingColumnMapping = @"Missing SourceColumn mapping for '{0}'.";




public const string ADP_NotSupportedEnumerationValue = @"The {0} enumeration value, {1}, is not supported by the {2} method.";
public const string ODBC_NotSupportedEnumerationValue = @"The {0} enumeration value, {1}, is not supported by the .Net Framework Odbc Data Provider.";
public const string OLEDB_NotSupportedEnumerationValue = @"The {0} enumeration value, {1}, is not supported by the .Net Framework OleDb Data Provider.";
public const string SQL_NotSupportedEnumerationValue = @"The {0} enumeration value, {1}, is not supported by the .Net Framework SqlClient Data Provider.";



public const string ADP_ComputerNameEx = @"Unable to retrieve the ComputerNameDnsFullyQualified, {0}.";



public const string ADP_MissingTableSchema = @"Missing the '{0}' DataTable for the '{1}' SourceTable.";



public const string ADP_InvalidSourceTable = @"SourceTable is required to be a non-empty string";

public const string ADP_MissingTableMapping = @"Missing SourceTable mapping: '{0}'";



public const string ADP_CommandTextRequired = @"{0}: CommandText property has not been initialized";
public const string ADP_ConnectionRequired = @"{0}: Connection property has not been initialized.";
public const string ADP_OpenConnectionRequired = @"{0} requires an open and available Connection. {1}";

public const string ADP_ConnectionRequired_Fill = @"Fill: SelectCommand.Connection property has not been initialized.";
public const string ADP_ConnectionRequired_FillPage = @"FillPage: SelectCommand.Connection property has not been initialized.";
public const string ADP_ConnectionRequired_FillSchema = @"FillSchema: SelectCommand.Connection property has not been initialized.";
public const string ADP_ConnectionRequired_Insert = @"Update requires the InsertCommand to have a connection object. The Connection property of the InsertCommand has not been initialized.";
public const string ADP_ConnectionRequired_Update = @"Update requires the UpdateCommand to have a connection object. The Connection property of the UpdateCommand has not been initialized.";
public const string ADP_ConnectionRequired_Delete = @"Update requires the DeleteCommand to have a connection object. The Connection property of the DeleteCommand has not been initialized.";
public const string ADP_ConnectionRequired_Batch = @"Update requires a connection object.  The Connection property has not been initialized.";
public const string ADP_ConnectionRequired_Clone = @"Update requires the command clone to have a connection object. The Connection property of the command clone has not been initialized.";
public const string ADP_ConnecitonRequired_UpdateRows = @"Update requires a connection.";

public const string ADP_OpenConnectionRequired_Insert = @"Update requires the {0}Command to have an open connection object. {1}";
public const string ADP_OpenConnectionRequired_Update = @"Update requires the {0}Command to have an open connection object. {1}";
public const string ADP_OpenConnectionRequired_Delete = @"Update requires the {0}Command to have an open connection object. {1}";
public const string ADP_OpenConnectionRequired_Clone = @"Update requires the updating command to have an open connection object. {1}";

public const string ADP_NoStoredProcedureExists = @"The stored procedure '{0}' doesn't exist.";
public const string ADP_TransactionCompleted = @"The transaction assigned to this command must be the most nested pending local transaction.";
public const string ADP_TransactionConnectionMismatch = @"The transaction is either not associated with the current connection or has been completed.";
public const string ADP_TransactionCompletedButNotDisposed = @"The transaction associated with the current connection has completed but has not been disposed.  The transaction must be disposed before the connection can be used to execute SQL statements.";
public const string ADP_TransactionRequired = @"{0} requires the command to have a transaction when the connection assigned to the command is in a pending local transaction.  The Transaction property of the command has not been initialized.";
public const string ADP_OpenResultSetExists = @"There is already an open SqlResultSet associated with this command which must be closed first.";
public const string ADP_OpenReaderExists = @"There is already an open DataReader associated with this Command which must be closed first.";
public const string ADP_DeriveParametersNotSupported = @"{0} DeriveParameters only supports CommandType.StoredProcedure, not CommandType.{1}.";
public const string ADP_CalledTwice = @"The method '{0}' cannot be called more than once for the same execution.";
public const string ADP_IncorrectAsyncResult = @"Incorrect async result.";



public const string ADP_MissingSelectCommand = @"The SelectCommand property has not been initialized before calling '{0}'.";
public const string ADP_UnwantedStatementType = @"The StatementType {0} is not expected here.";



public const string ADP_FillSchemaRequiresSourceTableName = @"FillSchema: expected a non-empty string for the SourceTable name.";



public const string ADP_InvalidMaxRecords = @"The MaxRecords value of {0} is invalid; the value must be >= 0.";
public const string ADP_InvalidStartRecord = @"The StartRecord value of {0} is invalid; the value must be >= 0.";

public const string ADP_FillRequiresSourceTableName = @"Fill: expected a non-empty string for the SourceTable name.";
public const string ADP_FillChapterAutoIncrement = @"Hierarchical chapter columns must map to an AutoIncrement DataColumn.";
public const string ADP_MissingDataReaderFieldType = @"DataReader.GetFieldType({0}) returned null.";
public const string ADP_OnlyOneTableForStartRecordOrMaxRecords = @"Only specify one item in the dataTables array when using non-zero values for startRecords or maxRecords.";


public const string ADP_UpdateRequiresSourceTable = @"Update unable to find TableMapping['{0}'] or DataTable '{0}'.";
public const string ADP_UpdateRequiresSourceTableName = @"Update: expected a non-empty SourceTable name.";
public const string ADP_MissingTableMappingDestination = @"Missing TableMapping when TableMapping.DataSetTable='{0}'.";

public const string ADP_UpdateRequiresCommandClone = @"Update requires the command clone to be valid.";
public const string ADP_UpdateRequiresCommandSelect = @"Auto SQL generation during Update requires a valid SelectCommand.";
public const string ADP_UpdateRequiresCommandInsert = @"Update requires a valid InsertCommand when passed DataRow collection with new rows.";
public const string ADP_UpdateRequiresCommandUpdate = @"Update requires a valid UpdateCommand when passed DataRow collection with modified rows.";
public const string ADP_UpdateRequiresCommandDelete = @"Update requires a valid DeleteCommand when passed DataRow collection with deleted rows.";


public const string ADP_UpdateMismatchRowTable = @"DataRow[{0}] is from a different DataTable than DataRow[0].";
public const string ADP_RowUpdatedErrors = @"RowUpdatedEvent: Errors occurred; no additional is information available.";
public const string ADP_RowUpdatingErrors = @"RowUpdatingEvent: Errors occurred; no additional is information available.";

public const string ADP_ResultsNotAllowedDuringBatch = @"When batching, the command's UpdatedRowSource property value of UpdateRowSource.FirstReturnedRecord or UpdateRowSource.Both is invalid.";

public const string ADP_UpdateConcurrencyViolation_Update = @"Concurrency violation: the UpdateCommand affected {0} of the expected {1} records.";
public const string ADP_UpdateConcurrencyViolation_Delete = @"Concurrency violation: the DeleteCommand affected {0} of the expected {1} records.";
public const string ADP_UpdateConcurrencyViolation_Batch = @"Concurrency violation: the batched command affected {0} of the expected {1} records.";


public const string ADP_InvalidCommandTimeout = @"Invalid CommandTimeout value {0}; the value must be >= 0.";

public const string ADP_UninitializedParameterSize = @"{1}[{0}]: the Size property has an invalid size of 0.";
public const string ADP_PrepareParameterType = @"{0}.Prepare method requires all parameters to have an explicitly set type.";
public const string ADP_PrepareParameterSize = @"{0}.Prepare method requires all variable length parameters to have an explicitly set non-zero Size.";
public const string ADP_PrepareParameterScale = @"{0}.Prepare method requires parameters of type '{1}' have an explicitly set Precision and Scale.";
public const string ADP_MismatchedAsyncResult = @"Mismatched end method call for asyncResult.  Expected call to {0} but {1} was called instead.";



public const string ADP_ClosedConnectionError = @"Invalid operation. The connection is closed.";

public const string ADP_ConnectionIsDisabled = @"The connection has been disabled.";

public const string ADP_LocalTransactionPresent = @"Cannot enlist in the transaction because a local transaction is in progress on the connection.  Finish local transaction and retry.";
public const string ADP_TransactionPresent = @"Connection currently has transaction enlisted.  Finish current transaction and retry.";

public const string ADP_EmptyDatabaseName = @"Database cannot be null, the empty string, or string of only whitespace.";
public const string ADP_DatabaseNameTooLong = @"The argument is too long.";
public const string ADP_InvalidConnectTimeoutValue = @"Invalid 'Connect Timeout' value which must be an integer >= 0.";




public const string ADP_InvalidSourceBufferIndex = @"Invalid source buffer (size of {0}) offset: {1}";
public const string ADP_InvalidDestinationBufferIndex = @"Invalid destination buffer (size of {0}) offset: {1}";

public const string ADP_DataReaderNoData = @"No data exists for the row/column.";


public const string ADP_NumericToDecimalOverflow = @"The numerical value is too large to fit into a 96 bit decimal.";


public const string ADP_StreamClosed = @"Invalid attempt to {0} when stream is closed.";
public const string ADP_InvalidSeekOrigin = @"Specified SeekOrigin value is invalid.";


public const string ADP_DynamicSQLJoinUnsupported = @"Dynamic SQL generation is not supported against multiple base tables.";
public const string ADP_DynamicSQLNoTableInfo = @"Dynamic SQL generation is not supported against a SelectCommand that does not return any base table information.";
public const string ADP_DynamicSQLNoKeyInfoDelete = @"Dynamic SQL generation for the DeleteCommand is not supported against a SelectCommand that does not return any key column information.";
public const string ADP_DynamicSQLNoKeyInfoUpdate = @"Dynamic SQL generation for the UpdateCommand is not supported against a SelectCommand that does not return any key column information.";
public const string ADP_DynamicSQLNoKeyInfoRowVersionDelete = @"Dynamic SQL generation for the DeleteCommand is not supported against a SelectCommand that does not contain a row version column.";
public const string ADP_DynamicSQLNoKeyInfoRowVersionUpdate = @"Dynamic SQL generation for the UpdateCommand is not supported against a SelectCommand that does not contain a row version column.";
public const string ADP_DynamicSQLNestedQuote = @"Dynamic SQL generation not supported against table names '{0}' that contain the QuotePrefix or QuoteSuffix character '{1}'.";
public const string ADP_NonSequentialColumnAccess = @"Invalid attempt to read from column ordinal '{0}'.  With CommandBehavior.SequentialAccess, you may only read from column ordinal '{1}' or greater.";

public const string ADP_InvalidDateTimeDigits = @"Data type '{0}' can not be formatted as a literal because it has an invalid date time digits.";
public const string ADP_InvalidFormatValue = @"The value can not be formatted as a literal of the requested type.";
public const string ADP_InvalidMaximumScale = @"Data type '{0}' can not be formatted as a literal because it has an invalid maximum scale.";
public const string ADP_LiteralValueIsInvalid = @"The literal value provided is not a valid literal for the data type '{0}'.";
public const string ADP_EvenLengthLiteralValue = @"'{0}':The length of the literal value must be even.";
public const string ADP_HexDigitLiteralValue = @"'{0}':The literal value must be a string with hexadecimal digits";
public const string ADP_QuotePrefixNotSet = @"{0} requires open connection when the quote prefix has not been set.";
public const string ADP_UnableToCreateBooleanLiteral = @"Can not determine the correct boolean literal values. Boolean literals can not be created.";
public const string ADP_UnsupportedNativeDataTypeOleDb = @"Literals of the native data type associated with data type '{0}' are not supported.";



public const string ADP_InvalidDataType = @"The parameter data type of {0} is invalid.";
public const string ADP_UnknownDataType = @"No mapping exists from object type {0} to a known managed provider native type.";
public const string ADP_UnknownDataTypeCode = @"Unable to handle an unknown TypeCode {0} returned by Type {1}.";
public const string ADP_DbTypeNotSupported = @"No mapping exists from DbType {0} to a known {1}.";
public const string ADP_VersionDoesNotSupportDataType = @"The version of SQL Server in use does not support datatype '{0}'.";
public const string ADP_ParameterValueOutOfRange = @"Parameter value '{0}' is out of range.";
public const string ADP_BadParameterName = @"Specified parameter name '{0}' is not valid.";
public const string ADP_MultipleReturnValue = @"Multiple return value parameters are not supported.";


public const string ADP_InvalidSizeValue = @"Invalid parameter Size value '{0}'. The value must be greater than or equal to 0.";
public const string ADP_NegativeParameter = @"Invalid value for argument '{0}'. The value must be greater than or equal to 0.";

public const string ADP_InvalidMetaDataValue = @"Invalid value for this metadata.";
public const string ADP_NotRowType = @"Metadata must be SqlDbType.Row";
public const string ADP_ParameterConversionFailed = @"Failed to convert parameter value from a {0} to a {1}.";



public const string ADP_ParallelTransactionsNotSupported = @"{0} does not support parallel transactions.";
public const string ADP_TransactionZombied = @"This {0} has completed; it is no longer usable.";

public const string ADP_DbRecordReadOnly = @"'{0}' cannot be called when the record is read only.";


public const string ADP_DbDataUpdatableRecordReadOnly = @"'{0}' cannot be called when the DbDataRecord is read only.";
public const string ADP_InvalidImplicitConversion = @"Implicit conversion of object type '{0}' to data type '{1}' is not supported.";

public const string ADP_InvalidBufferSizeOrIndex = @"Buffer offset '{1}' plus the bytes available '{0}' is greater than the length of the passed in buffer.";
public const string ADP_InvalidDataLength = @"Data length '{0}' is less than 0.";
public const string ADP_InvalidDataLength2 = @"Specified length '{0}' is out of range.";
public const string ADP_NonSeqByteAccess = @"Invalid {2} attempt at dataIndex '{0}'.  With CommandBehavior.SequentialAccess, you may only read from dataIndex '{1}' or greater.";

public const string ADP_OffsetOutOfRangeException = @"Offset must refer to a location within the value.";




















public const string ODBC_GetSchemaRestrictionRequired = @"""The ODBC managed provider requires that the TABLE_NAME restriction be specified and non-null for the GetSchema indexes collection.";


public const string ADP_InvalidArgumentValue = @"Invalid argument value for method '{0}'.";




public const string ADP_OdbcNoTypesFromProvider = @"The ODBC provider did not return results from SQLGETTYPEINFO.";



public const string ADP_NullDataTable = @"Unexpected null DataTable argument";
public const string ADP_NullDataSet = @"Unexpected null DataSet argument.";



public const string OdbcConnection_ConnectionStringTooLong = @"Connection string exceeds maximum allowed length of {0}.";

public const string Odbc_GetTypeMapping_UnknownType = @"{0} - unable to map type.";
public const string Odbc_UnknownSQLType = @"Unknown SQL type - {0}.";
public const string Odbc_UnknownURTType = @"Unknown URT type - {0}.";
public const string Odbc_NegativeArgument = @"Invalid negative argument!";
public const string Odbc_CantSetPropertyOnOpenConnection = @"Can't set property on an open connection.";
public const string Odbc_NoMappingForSqlTransactionLevel = @"No valid mapping for a SQL_TRANSACTION '{0}' to a System.Data.IsolationLevel enumeration value.";
public const string Odbc_CantEnableConnectionpooling = @"{0} - unable to enable connection pooling...";
public const string Odbc_CantAllocateEnvironmentHandle = @"{0} - unable to allocate an environment handle.";
public const string Odbc_FailedToGetDescriptorHandle = @"{0} - unable to get descriptor handle.";
public const string Odbc_NotInTransaction = @"Not in a transaction";
public const string Odbc_UnknownOdbcType = @"Invalid OdbcType enumeration value={0}.";
public const string Odbc_NullData = @"Use IsDBNull when DBNull.Value data is expected.";
public const string Odbc_ExceptionMessage = @"{0} [{1}] {2}";
public const string Odbc_ExceptionNoInfoMsg = @"{0} - no error information available";

public const string Odbc_ConnectionClosed = @"The connection is closed.";
public const string Odbc_OpenConnectionNoOwner = @"An internal connection does not have an owner.";




public const string Odbc_MDACWrongVersion = @"The .Net Framework Odbc Data Provider requires Microsoft Data Access Components(MDAC) version 2.6 or later.  Version {0} was found currently installed.";
public const string OleDb_MDACWrongVersion = @"The .Net Framework OleDb Data Provider requires Microsoft Data Access Components(MDAC) version 2.6 or later.  Version {0} was found currently installed.";



public const string OleDb_SchemaRowsetsNotSupported = @"'{0}' interface is not supported by the '{1}' provider.  GetOleDbSchemaTable is unavailable with the current provider.";
public const string OleDb_NoErrorInformation2 = @"'{0}' failed with no error message available, result code: {1}.";
public const string OleDb_NoErrorInformation = @"No error message available, result code: {0}.";
public const string OleDb_MDACNotAvailable = @"The .Net Framework Data Providers require Microsoft Data Access Components(MDAC).  Please install Microsoft Data Access Components(MDAC) version 2.6 or later.";
public const string OleDb_MSDASQLNotSupported = @"The .Net Framework Data Provider for OLEDB (System.Data.OleDb) does not support the Microsoft OLE DB Provider for ODBC Drivers (MSDASQL). Use the .Net Framework Data Provider for ODBC (System.Data.Odbc).";
public const string OleDb_PossiblePromptNotUserInteractive = @"The .Net Framework Data Provider for OLEDB will not allow the OLE DB Provider to prompt the user in a non-interactive environment.";
public const string OleDb_ProviderUnavailable = @"The '{0}' provider is not registered on the local machine.";
public const string OleDb_CommandTextNotSupported = @"The ICommandText interface is not supported by the '{0}' provider. Use CommandType.TableDirect instead.";
public const string OleDb_TransactionsNotSupported = @"The ITransactionLocal interface is not supported by the '{0}' provider.  Local transactions are unavailable with the current provider.";
public const string OleDb_ConnectionStringSyntax = @"Format of the initialization string does not conform to the OLE DB specification.  Starting around char[{0}] in the connection string.";
public const string OleDb_AsynchronousNotSupported = @"'Asynchronous Processing' is not a supported feature of the .Net Framework Data OLE DB Provider(System.Data.OleDb).";
public const string OleDb_NoProviderSpecified = @"An OLE DB Provider was not specified in the ConnectionString.  An example would be, 'Provider=SQLOLEDB;'.";
public const string OleDb_InvalidProviderSpecified = @"The OLE DB Provider specified in the ConnectionString is too long.";
public const string OleDb_InvalidRestrictionsDbInfoKeywords = @"No restrictions are expected for the DbInfoKeywords OleDbSchemaGuid.";
public const string OleDb_InvalidRestrictionsDbInfoLiteral = @"No restrictions are expected for the DbInfoLiterals OleDbSchemaGuid.";
public const string OleDb_InvalidRestrictionsSchemaGuids = @"No restrictions are expected for the schema guid OleDbSchemaGuid.";
public const string OleDb_NotSupportedSchemaTable = @"The {0} OleDbSchemaGuid is not a supported schema by the '{1}' provider.";
public const string OleDb_ConfigWrongNumberOfValues = @"The '{0}' configuration setting has the wrong number of values.";
public const string OleDb_ConfigUnableToLoadXmlMetaDataFile = @"Unable to load the XML file specified in configuration setting '{0}'.";


public const string OleDb_CommandParameterBadAccessor = @"Command parameter[{0}] '{1}' is invalid.";
public const string OleDb_CommandParameterCantConvertValue = @"Command parameter[{0}] '{1}' data value could not be converted for reasons other than sign mismatch or data overflow.";
public const string OleDb_CommandParameterSignMismatch = @"Conversion failed for command parameter[{0}] '{1}' because the data value was signed and the type used by the provider was unsigned.";
public const string OleDb_CommandParameterDataOverflow = @"Conversion failed for command parameter[{0}] '{1}' because the data value overflowed the type used by the provider.";
public const string OleDb_CommandParameterUnavailable = @"Provider encountered an error while sending command parameter[{0}] '{1}' value and stopped processing.";
public const string OleDb_CommandParameterDefault = @"Parameter[{0}] '{1}' has no default value.";
public const string OleDb_CommandParameterError = @"Error occurred with parameter[{0}]: {1}.";

public const string OleDb_BadStatus_ParamAcc = @"System.Data.OleDb.OleDbDataAdapter internal error: invalid parameter accessor: {0} {1}.";
public const string OleDb_UninitializedParameters = @"Parameter[{0}]: the OleDbType property is uninitialized: OleDbType.{1}.";
public const string OleDb_NoProviderSupportForParameters = @"The ICommandWithParameters interface is not supported by the '{0}' provider.  Command parameters are unsupported with the current provider.";
public const string OleDb_NoProviderSupportForSProcResetParameters = @"Retrieving procedure parameter information is not supported by the '{0}' provider.";


public const string OleDb_CanNotDetermineDecimalSeparator = @"Can not determine the server's decimal separator. Non-integer numeric literals can not be created.";


public const string OleDb_Fill_NotADODB = @"Object is not an ADODB.RecordSet or an ADODB.Record.";
public const string OleDb_Fill_EmptyRecordSet = @"Unable to retrieve the '{0}' interface from the ADODB.RecordSet object.";
public const string OleDb_Fill_EmptyRecord = @"Unable to retrieve the IRow interface from the ADODB.Record object.";


public const string OleDb_ISourcesRowsetNotSupported = @"Type does not support the OLE DB interface ISourcesRowset";


public const string OleDb_IDBInfoNotSupported = @"Cannot construct the ReservedWords schema collection because the provider does not support IDBInfo.";



public const string OleDb_PropertyNotSupported = @"The property's value was not set because the provider did not support the '{0}' property, or the consumer attempted to get or set values of properties not in the Initialization property group and the data source object is uninitialized.";
public const string OleDb_PropertyBadValue = @"Failed to initialize the '{0}' property for one of the following reasons:\r\n\tThe value data type was not the data type of the property or was not null. For example, the property was DBPROP_MEMORYUSAGE, which has a data type of Int32, and the data type was Int64.\r\n\tThe value was not a valid value. For example, the property was DBPROP_MEMORYUSAGE and the value was negative.\r\n\tThe value was a valid value for the property and the provider supports the property as a settable property, but the provider does not support the value specified. This includes the case where the value was added to the property in OLE DB after the provider was written.";
public const string OleDb_PropertyBadOption = @"The value of Options was invalid.";
public const string OleDb_PropertyBadColumn = @"The ColumnID element was invalid.";
public const string OleDb_PropertyNotAllSettable = @"A '{0}' property was specified to be applied to all columns but could not be applied to one or more of them.";
public const string OleDb_PropertyNotSettable = @"The '{0}' property was read-only, or the consumer attempted to set values of properties in the Initialization property group after the data source object was initialized. Consumers can set the value of a read-only property to its current value. This status is also returned if a settable column property could not be set for the particular column.";
public const string OleDb_PropertyNotSet = @"The optional '{0}' property's value was not set to the specified value and setting the property to the specified value was not possible.";
public const string OleDb_PropertyConflicting = @"The '{0}'property's value was not set because doing so would have conflicted with an existing property.";
public const string OleDb_PropertyNotAvailable = @"(Reserved).";
public const string OleDb_PropertyStatusUnknown = @"The provider returned an unknown DBPROPSTATUS_ value '{0}'.";



public const string OleDb_BadAccessor = @"Accessor validation was deferred and was performed while the method returned data. The binding was invalid for this column or parameter.";
public const string OleDb_BadStatusRowAccessor = @"OleDbDataAdapter internal error: invalid row set accessor: Ordinal={0} Status={1}.";
public const string OleDb_CantConvertValue = @"The data value could not be converted for reasons other than sign mismatch or data overflow. For example, the data was corrupted in the data store but the row was still retrievable.";
public const string OleDb_CantCreate = @"The provider could not allocate memory in which to return {0} data.";
public const string OleDb_DataOverflow = @"Conversion failed because the {0} data value overflowed the type specified for the {0} value part in the consumer's buffer.";
public const string OleDb_GVtUnknown = @"OleDbDataAdapter internal error: [get] Unknown OLE DB data type: 0x{0} ({1}).";
public const string OleDb_SignMismatch = @"Conversion failed because the {0} data value was signed and the type specified for the {0} value part in the consumer's buffer was unsigned.";
public const string OleDb_SVtUnknown = @"OleDbDataAdapter internal error: [set] Unknown OLE DB data type: 0x{0} ({1}).";
public const string OleDb_Unavailable = @"The provider could not determine the {0} value. For example, the row was just created, the default for the {0} column was not available, and the consumer had not yet set a new {0} value.";
public const string OleDb_UnexpectedStatusValue = @"OLE DB Provider returned an unexpected status value of {0}.";
public const string OleDb_ThreadApartmentState = @"The OleDbDataReader.Read must be used from the same thread on which is was created if that thread's ApartmentState was not ApartmentState.MTA.";

public const string OleDb_NoErrorMessage = @"Unspecified error: {0}";
public const string OleDb_FailedGetDescription = @"IErrorInfo.GetDescription failed with {0}.";
public const string OleDb_FailedGetSource = @"IErrorInfo.GetSource failed with {0}.";
public const string OleDb_DBBindingGetVector = @"DBTYPE_VECTOR data is not supported by the .Net Framework Data OLE DB Provider(System.Data.OleDb).";






public const string ADP_InvalidMinMaxPoolSizeValues = @"Invalid min or max pool size values, min pool size cannot be greater than the max pool size.";
public const string ADP_ObsoleteKeyword = @"The '{0}' keyword is obsolete. Use '{1}' instead.";
public const string SQL_CannotGetDTCAddress = @"Unable to get the address of the distributed transaction coordinator for the server, from the server.  Is DTC enabled on the server?";
public const string SQL_InvalidOptionLength = @"The length of the value for the connection parameter <{0}> exceeds the maximum allowed 65535 characters.";
public const string SQL_InvalidPacketSizeValue = @"Invalid 'Packet Size'.  The value must be an integer >= 512 and <= 32768.";
public const string SQL_NullEmptyTransactionName = @"Invalid transaction or invalid name for a point at which to save within the transaction.";
public const string SQL_SnapshotNotSupported = @"The {0} enumeration value, {1}, is not supported by SQL Server 7.0 or SQL Server 2000.";
public const string SQL_UserInstanceFailoverNotCompatible = @"User Instance and Failover are not compatible options.  Please choose only one of the two in the connection string.";

public const string SQL_EncryptionNotSupportedByClient = @"The instance of SQL Server you attempted to connect to requires encryption but this machine does not support it.";
public const string SQL_EncryptionNotSupportedByServer = @"The instance of SQL Server you attempted to connect to does not support encryption.";
public const string SQL_InvalidSQLServerVersionUnknown = @"Unsupported SQL Server version.  The .Net Framework SqlClient Data Provider can only be used with SQL Server versions 7.0 and later.";

public const string SQL_CannotModifyPropertyAsyncOperationInProgress = @"{0} cannot be changed while async operation is in progress.";
public const string SQL_AsyncConnectionRequired = @"This command requires an asynchronous connection. Set \""Asynchronous Processing=true\"" in the connection string.";
public const string SQL_FatalTimeout = @"Timeout expired.  The connection has been broken as a result.";
public const string SQL_InstanceFailure = @"Instance failure.";

public const string SQL_ChangePasswordArgumentMissing = @"The '{0}' argument must not be null or empty.";
public const string SQL_ChangePasswordConflictsWithSSPI = @"ChangePassword can only be used with SQL authentication, not with integrated security.";
public const string SQL_ChangePasswordUseOfUnallowedKey = @"The keyword '{0}' must not be specified in the connectionString argument to ChangePassword.";
public const string SQL_UnknownSysTxIsolationLevel = @"Unrecognized System.Transactions.IsolationLevel enumeration value: {0}.";
public const string SQL_InvalidPartnerConfiguration = @"Server {0}, database {1} is not configured for database mirroring.";
public const string SQL_MarsUnsupportedOnConnection = @"The connection does not support MultipleActiveResultSets.";


public const string SQL_ChangePasswordRequiresYukon = @"ChangePassword requires SQL Server 9.0 or later.";
public const string SQL_NonLocalSSEInstance = @"SSE Instance re-direction is not supported for non-local user instances.";



public const string SQL_AsyncOperationCompleted = @"The asynchronous operation has already completed.";
public const string SQL_PendingBeginXXXExists = @"The command execution cannot proceed due to a pending asynchronous operation already in progress.";
public const string SQL_NonXmlResult = @"Invalid command sent to ExecuteXmlReader.  The command must return an Xml result.";

public const string SQL_NotificationsRequireYukon = @"Notifications require SQL Server 9.0 or later.";



public const string SQL_InvalidUdt3PartNameFormat = @"Invalid 3 part name format for UdtTypeName.";
public const string SQL_InvalidParameterTypeNameFormat = @"Invalid 3 part name format for TypeName.";
public const string SQL_InvalidParameterNameLength = @"The length of the parameter '{0}' exceeds the limit of 128 characters.";
public const string SQL_PrecisionValueOutOfRange = @"Precision value '{0}' is either less than 0 or greater than the maximum allowed precision of 38.";
public const string SQL_ScaleValueOutOfRange = @"Scale value '{0}' is either less than 0 or greater than the maximum allowed scale of 38.";
public const string SQL_TimeScaleValueOutOfRange = @"Scale value '{0}' is either less than 0 or greater than the maximum allowed scale of 7.";

public const string SQL_ParameterInvalidVariant = @"Parameter '{0}' exceeds the size limit for the sql_variant datatype.";
public const string SQL_ParameterTypeNameRequired = @"The {0} type parameter '{1}' must have a valid type name.";





public const string SQL_InvalidInternalPacketSize = @"Invalid internal packet size:";
public const string SQL_InvalidTDSVersion = @"The SQL Server instance returned an invalid or unsupported protocol version during login negotiation.";
public const string SQL_InvalidTDSPacketSize = @"Invalid Packet Size.";
public const string SQL_ParsingError = @"Internal connection fatal error.";
public const string SQL_ConnectionLockedForBcpEvent = @"The connection cannot be used because there is an ongoing operation that must be finished.";
public const string SQL_SNIPacketAllocationFailure = @"Memory allocation for internal connection failed.";

public const string SQL_SmallDateTimeOverflow = @"SqlDbType.SmallDateTime overflow.  Value '{0}' is out of range.  Must be between 1/1/1900 12:00:00 AM and 6/6/2079 11:59:59 PM.";
public const string SQL_TimeOverflow = @"SqlDbType.Time overflow.  Value '{0}' is out of range.  Must be between 00:00:00.0000000 and 23:59:59.9999999.";
public const string SQL_MoneyOverflow = @"SqlDbType.SmallMoney overflow.  Value '{0}' is out of range.  Must be between -214,748.3648 and 214,748.3647.";

public const string SQL_CultureIdError = @"The Collation specified by SQL Server is not supported.";
public const string SQL_OperationCancelled = @"Operation cancelled by user.";
public const string SQL_SevereError = @"A severe error occurred on the current command.  The results, if any, should be discarded.";
public const string SQL_SSPIGenerateError = @"The target principal name is incorrect.  Cannot generate SSPI context.";
public const string SQL_InvalidSSPIPacketSize = @"Invalid SSPI packet size.";
public const string SQL_SSPIInitializeError = @"Cannot initialize SSPI package.";
public const string SQL_Timeout = @"Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding.";
public const string SQL_Timeout_PreLogin_Begin = @"Connection Timeout Expired.  The timeout period elapsed at the start of the pre-login phase.  This could be because of insufficient time provided for connection timeout.";
public const string SQL_Timeout_PreLogin_InitializeConnection = @"Connection Timeout Expired.  The timeout period elapsed while attempting to create and initialize a socket to the server.  This could be either because the server was unreachable or unable to respond back in time.";
public const string SQL_Timeout_PreLogin_SendHandshake = @"Connection Timeout Expired.  The timeout period elapsed while making a pre-login handshake request.  This could be because the server was unable to respond back in time.";
public const string SQL_Timeout_PreLogin_ConsumeHandshake = @"Connection Timeout Expired.  The timeout period elapsed while attempting to consume the pre-login handshake acknowledgement.  This could be because the pre-login handshake failed or the server was unable to respond back in time.";
public const string SQL_Timeout_Login_Begin = @"Connection Timeout Expired.  The timeout period elapsed at the start of the login phase.  This could be because of insufficient time provided for connection timeout.";
public const string SQL_Timeout_Login_ProcessConnectionAuth = @"Connection Timeout Expired.  The timeout period elapsed while attempting to authenticate the login.  This could be because the server failed to authenticate the user or the server was unable to respond back in time.";
public const string SQL_Timeout_PostLogin = @"Connection Timeout Expired.  The timeout period elapsed during the post-login phase.  The connection could have timed out while waiting for server to complete the login process and respond; Or it could have timed out while attempting to create multiple active connections.";
public const string SQL_Timeout_FailoverInfo = @"This failure occured while attempting to connect to the {0} server.";
public const string SQL_Timeout_RoutingDestinationInfo = @"This failure occurred while attempting to connect to the routing destination. The duration spent while attempting to connect to the original server was - [Pre-Login] initialization={0}; handshake={1}; [Login] initialization={2}; authentication={3}; [Post-Login] complete={4};  ";
public const string SQL_Duration_PreLogin_Begin = @"The duration spent while attempting to connect to this server was - [Pre-Login] initialization={0};";
public const string SQL_Duration_PreLoginHandshake = @"The duration spent while attempting to connect to this server was - [Pre-Login] initialization={0}; handshake={1}; ";
public const string SQL_Duration_Login_Begin = @"The duration spent while attempting to connect to this server was - [Pre-Login] initialization={0}; handshake={1}; [Login] initialization={2}; ";
public const string SQL_Duration_Login_ProcessConnectionAuth = @"The duration spent while attempting to connect to this server was - [Pre-Login] initialization={0}; handshake={1}; [Login] initialization={2}; authentication={3}; ";
public const string SQL_Duration_PostLogin = @"The duration spent while attempting to connect to this server was - [Pre-Login] initialization={0}; handshake={1}; [Login] initialization={2}; authentication={3}; [Post-Login] complete={4}; ";
public const string SQL_UserInstanceFailure = @"A user instance was requested in the connection string but the server specified does not support this option.";



public const string SQL_ExceedsMaxDataLength = @"Specified data length {0} exceeds the allowed maximum length of {1}.";

public const string SQL_InvalidRead = @"Invalid attempt to read when no data is present.";
public const string SQL_NonBlobColumn = @"Invalid attempt to GetBytes on column '{0}'.  The GetBytes function can only be used on columns of type Text, NText, or Image.";
public const string SQL_NonCharColumn = @"Invalid attempt to GetChars on column '{0}'.  The GetChars function can only be used on columns of type Text, NText, Xml, VarChar or NVarChar.";
public const string SQL_StreamNotSupportOnColumnType = @"Invalid attempt to GetStream on column '{0}'. The GetStream function can only be used on columns of type Binary, Image, Udt or VarBinary.";
public const string SQL_TextReaderNotSupportOnColumnType = @"Invalid attempt to GetTextReader on column '{0}'. The GetTextReader function can only be used on columns of type Char, NChar, NText, NVarChar, Text or VarChar.";
public const string SQL_XmlReaderNotSupportOnColumnType = @"Invalid attempt to GetXmlReader on column '{0}'. The GetXmlReader function can only be used on columns of type Xml.";

public const string SQL_InvalidBufferSizeOrIndex = @"Buffer offset '{1}' plus the bytes available '{0}' is greater than the length of the passed in buffer.";
public const string SQL_InvalidDataLength = @"Data length '{0}' is less than 0.";



public const string SQL_SqlResultSetClosed = @"Invalid attempt to call method {0} when SqlResultSet is closed.";
public const string SQL_SqlResultSetClosed2 = @"Operation cannot be completed because the SqlResultSet is closed.";
public const string SQL_SqlRecordReadOnly = @"'{0}' cannot be called when the record is read only.";
public const string SQL_SqlRecordReadOnly2 = @"Operation cannot be completed because the record is read only.";
public const string SQL_SqlResultSetRowDeleted = @"Invalid attempt to call method {0} when the current row is deleted";
public const string SQL_SqlResultSetRowDeleted2 = @"Operation cannot be completed because the current row is deleted";
public const string SQL_SqlResultSetCommandNotInSameConnection = @"Operation cannot be completed because the command that created the SqlResultSet has been dissociated from the original connection. SqlResultSet is closed.";
public const string SQL_SqlResultSetNoAcceptableCursor = @"SqlResultSet could not be created for the given query with the desired options.";

public const string SQL_SqlUpdatableRecordReadOnly = @"'{0}' cannot be called when the SqlDataRecord is read only.";



public const string SQL_BulkLoadMappingInaccessible = @"The mapped collection is in use and cannot be accessed at this time;";
public const string SQL_BulkLoadMappingsNamesOrOrdinalsOnly = @"Mappings must be either all name or all ordinal based.";
public const string SQL_BulkLoadCannotConvertValue = @"The given value of type {0} from the data source cannot be converted to type {1} of the specified target column.";
public const string SQL_BulkLoadNonMatchingColumnMapping = @"The given ColumnMapping does not match up with any column in the source or destination.";
public const string SQL_BulkLoadNonMatchingColumnName = @"The given ColumnName '{0}' does not match up with any column in data source.";
public const string SQL_BulkLoadStringTooLong = @"String or binary data would be truncated.";
public const string SQL_BulkLoadInvalidTimeout = @"Timeout Value '{0}' is less than 0.";
public const string SQL_BulkLoadInvalidVariantValue = @"Value cannot be converted to SqlVariant.";
public const string SQL_BulkLoadExistingTransaction = @"Unexpected existing transaction.";
public const string SQL_BulkLoadNoCollation = @"Failed to obtain column collation information for the destination table. If the table is not in the current database the name must be qualified using the database name (e.g. [mydb]..[mytable](e.g. [mydb]..[mytable]); this also applies to temporary-tables (e.g. #mytable would be specified as tempdb..#mytable).";
public const string SQL_BulkLoadConflictingTransactionOption = @"Must not specify SqlBulkCopyOption.UseInternalTransaction and pass an external Transaction at the same time.";
public const string SQL_BulkLoadInvalidOperationInsideEvent = @"Function must not be called during event.";
public const string SQL_BulkLoadMissingDestinationTable = @"The DestinationTableName property must be set before calling this method.";
public const string SQL_BulkLoadInvalidDestinationTable = @"Cannot access destination table '{0}'.";
public const string SQL_BulkLoadNotAllowDBNull = @"Column '{0}' does not allow DBNull.Value.";
public const string Sql_BulkLoadLcidMismatch = @"The locale id '{0}' of the source column '{1}' and the locale id '{2}' of the destination column '{3}' do not match.";
public const string SQL_BulkLoadPendingOperation = @"Attempt to invoke bulk copy on an object that has a pending operation.";



public const string SQL_ConnectionDoomed = @"The requested operation cannot be completed because the connection has been broken.";
public const string SQL_OpenResultCountExceeded = @"Open result count exceeded.";



public const string SQL_BatchedUpdatesNotAvailableOnContextConnection = @"Batching updates is not supported on the context connection.";
public const string SQL_ContextAllowsLimitedKeywords = @"The only additional connection string keyword that may be used when requesting the context connection is the Type System Version keyword.";
public const string SQL_ContextAllowsOnlyTypeSystem2005 = @"The context connection does not support Type System Version=SQL Server 2000.";
public const string SQL_ContextConnectionIsInUse = @"The context connection is already in use.";
public const string SQL_ContextUnavailableOutOfProc = @"The requested operation requires a SqlClr context, which is only available when running in the Sql Server process.";
public const string SQL_ContextUnavailableWhileInProc = @"The requested operation requires a Sql Server execution thread.  The current thread was started by user code or other non-Sql Server engine code.";
public const string SQL_NestedTransactionScopesNotSupported = @"Nested TransactionScopes are not supported.";
public const string SQL_NotAvailableOnContextConnection = @"The requested operation is not available on the context connection.";
public const string SQL_NotificationsNotAvailableOnContextConnection = @"Notifications are not available on the context connection.";
public const string SQL_UnexpectedSmiEvent = @"Unexpected server event: {0}.";
public const string SQL_UserInstanceNotAvailableInProc = @"User instances are not allowed when running in the Sql Server process.";
public const string SQL_ArgumentLengthMismatch = @"The length of '{0}' must match the length of '{1}'.";
public const string SQL_InvalidSqlDbTypeWithOneAllowedType = @"The SqlDbType '{0}' is invalid for {1}.  Only {2} is supported.";
public const string SQL_PipeErrorRequiresSendEnd = @"An error occurred with a prior row sent to the SqlPipe.  SendResultsEnd must be called before anything else con be sent.";
public const string SQL_TooManyValues = @"Too many values.";
public const string SQL_StreamWriteNotSupported = @"The Stream does not support writing.";
public const string SQL_StreamReadNotSupported = @"The Stream does not support reading.";
public const string SQL_StreamSeekNotSupported = @"The Stream does not support seeking.";



public const string SQL_ExClientConnectionId = @"ClientConnectionId:{0}";
public const string SQL_ExErrorNumberStateClass = @"Error Number:{0},State:{1},Class:{2}";
public const string SQL_ExOriginalClientConnectionId = @"ClientConnectionId before routing:{0}";
public const string SQL_ExRoutingDestination = @"Routing Destination:{0}";



public const string SqlMisc_NullString = @"Null";
public const string SqlMisc_MessageString = @"Message";
public const string SqlMisc_ArithOverflowMessage = @"Arithmetic Overflow.";
public const string SqlMisc_DivideByZeroMessage = @"Divide by zero error encountered.";
public const string SqlMisc_NullValueMessage = @"Data is Null. This method or property cannot be called on Null values.";
public const string SqlMisc_TruncationMessage = @"Numeric arithmetic causes truncation.";
public const string SqlMisc_DateTimeOverflowMessage = @"SqlDateTime overflow. Must be between 1/1/1753 12:00:00 AM and 12/31/9999 11:59:59 PM.";
public const string SqlMisc_ConcatDiffCollationMessage = @"Two strings to be concatenated have different collation.";
public const string SqlMisc_CompareDiffCollationMessage = @"Two strings to be compared have different collation.";
public const string SqlMisc_InvalidFlagMessage = @"Invalid flag value.";
public const string SqlMisc_NumeToDecOverflowMessage = @"Conversion from SqlDecimal to Decimal overflows.";
public const string SqlMisc_ConversionOverflowMessage = @"Conversion overflows.";
public const string SqlMisc_InvalidDateTimeMessage = @"Invalid SqlDateTime.";
public const string SqlMisc_TimeZoneSpecifiedMessage = @"A time zone was specified. SqlDateTime does not support time zones.";
public const string SqlMisc_InvalidArraySizeMessage = @"Invalid array size.";
public const string SqlMisc_InvalidPrecScaleMessage = @"Invalid numeric precision/scale.";
public const string SqlMisc_FormatMessage = @"The input wasn't in a correct format.";
public const string SqlMisc_SqlTypeMessage = @"SqlType error.";
public const string SqlMisc_LenTooLargeMessage = @"The SqlBytes and SqlChars don't support length of more than 2GB in this version.";
public const string SqlMisc_StreamErrorMessage = @"An error occurred while reading.";
public const string SqlMisc_StreamClosedMessage = @"Stream has been closed or disposed.";
public const string SqlMisc_NoBufferMessage = @"There is no buffer. Read or write operation failed.";
public const string SqlMisc_SetNonZeroLenOnNullMessage = @"Cannot set to non-zero length, because current value is Null.";
public const string SqlMisc_BufferInsufficientMessage = @"The buffer is insufficient. Read or write operation failed.";
public const string SqlMisc_WriteNonZeroOffsetOnNullMessage = @"Cannot write to non-zero offset, because current value is Null.";
public const string SqlMisc_WriteOffsetLargerThanLenMessage = @"Cannot write from an offset that is larger than current length. It would leave uninitialized data in the buffer.";
public const string SqlMisc_TruncationMaxDataMessage = @"Data returned is larger than 2Gb in size. Use SequentialAccess command behavior in order to get all of the data.";
public const string SqlMisc_InvalidFirstDayMessage = @"Argument to GetDayOfWeek must be integer between 1 and 7.";
public const string SqlMisc_NotFilledMessage = @"SQL Type has not been loaded with data.";
public const string SqlMisc_AlreadyFilledMessage = @"SQL Type has already been loaded with data.";
public const string SqlMisc_ClosedXmlReaderMessage = @"Invalid attempt to access a closed XmlReader.";
public const string SqlMisc_InvalidOpStreamClosed = @"Invalid attempt to call {0} when the stream is closed.";
public const string SqlMisc_InvalidOpStreamNonWritable = @"Invalid attempt to call {0} when the stream non-writable.";
public const string SqlMisc_InvalidOpStreamNonReadable = @"Invalid attempt to call {0} when the stream non-readable.";
public const string SqlMisc_InvalidOpStreamNonSeekable = @"Invalid attempt to call {0} when the stream is non-seekable.";
public const string SqlMisc_SubclassMustOverride = @"Subclass did not override a required method.";




public const string Sql_CanotCreateNormalizer = @"Cannot create normalizer for '{0}'.";
public const string Sql_InternalError = @"Internal Error";
public const string Sql_NullCommandText = @"Command parameter must have a non null and non empty command text.";
public const string Sql_MismatchedMetaDataDirectionArrayLengths = @"MetaData parameter array must have length equivalent to ParameterDirection array argument.";


public const string ADP_AdapterMappingExceptionMessage = @"Data adapter mapping error.";
public const string ADP_DataAdapterExceptionMessage = @"Data adapter error.";
public const string ADP_DBConcurrencyExceptionMessage = @"DB concurrency violation.";
public const string ADP_OperationAborted = @"Operation aborted.";
public const string ADP_OperationAbortedExceptionMessage = @"Operation aborted due to an exception (see InnerException for details).";





public const string DataAdapter_AcceptChangesDuringFill = @"Whether or not Fill will call DataRow.AcceptChanges.";
public const string DataAdapter_AcceptChangesDuringUpdate = @"Whether or not Update will call DataRow.AcceptChanges.";
public const string DataAdapter_ContinueUpdateOnError = @"Whether or not to continue to the next DataRow when the Update events, RowUpdating and RowUpdated, Status is UpdateStatus.ErrorsOccurred.";
public const string DataAdapter_FillLoadOption = @"How the adapter fills the DataTable from the DataReader.";
public const string DataAdapter_MissingMappingAction = @"The action taken when a table or column in the TableMappings is missing.";
public const string DataAdapter_MissingSchemaAction = @"The action taken when a table or column in the DataSet is missing.";
public const string DataAdapter_TableMappings = @"How to map source table to DataSet table.";
public const string DataAdapter_FillError = @"Event triggered when a recoverable error occurs during Fill.";
public const string DataAdapter_ReturnProviderSpecificTypes = @"Should Fill return provider specific values or common CLSCompliant values.";


public const string DataColumnMapping_DataSetColumn = @"DataColumn.ColumnName";
public const string DataColumnMapping_SourceColumn = @"Source column name - case sensitive.";


public const string DataColumnMappings_Count = @"The number of items in the collection";
public const string DataColumnMappings_Item = @"The specified DataColumnMapping object.";


public const string DataTableMapping_ColumnMappings = @"Individual columns mappings when this table mapping is matched.";
public const string DataTableMapping_DataSetTable = @"DataTable.TableName";
public const string DataTableMapping_SourceTable = @"The DataTableMapping source table name. This name is case sensitive.";


public const string DataTableMappings_Count = @"The number of items in the collection";
public const string DataTableMappings_Item = @"The specified DataTableMapping object";


public const string DbDataAdapter_DeleteCommand = @"Used during Update for deleted rows in DataSet.";
public const string DbDataAdapter_InsertCommand = @"Used during Update for new rows in DataSet.";
public const string DbDataAdapter_SelectCommand = @"Used during Fill/FillSchema.";
public const string DbDataAdapter_UpdateCommand = @"Used during Update for modified rows in DataSet.";
public const string DbDataAdapter_RowUpdated = @"Event triggered before every DataRow during Update.";
public const string DbDataAdapter_RowUpdating = @"Event triggered after every DataRow during Update.";
public const string DbDataAdapter_UpdateBatchSize = @"Number of rows to batch together before executing against the data source.";


public const string DbTable_Connection = @"Connection used if the the Select/Insert/Update/DeleteCommands do not already have a connection.";
public const string DbTable_DeleteCommand = @"Used during Update for deleted rows in the DataTable.";
public const string DbTable_InsertCommand = @"Used during Update for new rows in the DataTable.";
public const string DbTable_SelectCommand = @"Used during Fill.";
public const string DbTable_UpdateCommand = @"Used during Update for modified rows in the DataTable.";
public const string DbTable_ReturnProviderSpecificTypes = @"Should Fill return provider specific values or common CLSCompliant values.";
public const string DbTable_TableMapping = @"How to map source table to DataTable.";
public const string DbTable_ConflictDetection = @"How are the Insert/Update/DeleteCommands generated when not set by the user.";
public const string DbTable_UpdateBatchSize = @"Number of rows to batch together before executing against the data source.";



public const string DbConnectionString_ConnectionString = @"The connection string used to connect to the Data Source.";
public const string DbConnectionString_Driver = @"The name of the ODBC Driver to use when connecting to the Data Source.";
public const string DbConnectionString_DSN = @"The DSN to use when connecting to the Data Source.";
public const string DbConnectionString_AdoNetPooler = @"When true, indicates that managed connection pooling should be used.";
public const string DbConnectionString_FileName = @"The UDL file to use when connecting to the Data Source.";
public const string DbConnectionString_OleDbServices = @"Specifies which OLE DB Services to enable or disable with the OleDb Provider.";
public const string DbConnectionString_Provider = @"The name of the OLE DB Provider to use when connecting to the Data Source.";
public const string DbConnectionString_ApplicationName = @"The name of the application.";
public const string DbConnectionString_AsynchronousProcessing = @"When true, enables usage of the Asynchronous functionality in the .Net Framework Data Provider.";
public const string DbConnectionString_AttachDBFilename = @"The name of the primary file, including the full path name, of an attachable database.";
public const string DbConnectionString_ConnectTimeout = @"The length of time (in seconds) to wait for a connection to the server before terminating the attempt and generating an error.";
public const string DbConnectionString_ConnectionReset = @"When true, indicates the connection state is reset when removed from the pool.";
public const string DbConnectionString_ContextConnection = @"When true, indicates the connection should be from the Sql Server context.  Available only when running in the Sql Server process.";
public const string DbConnectionString_CurrentLanguage = @"The SQL Server Language record name.";
public const string DbConnectionString_DataSource = @"Indicates the name of the data source to connect to.";
public const string DbConnectionString_Encrypt = @"When true, SQL Server uses SSL encryption for all data sent between the client and server if the server has a certificate installed.";
public const string DbConnectionString_Enlist = @"Sessions in a Component Services (or MTS, if you are using Microsoft Windows NT) environment should automatically be enlisted in a global transaction where required.";
public const string DbConnectionString_InitialCatalog = @"The name of the initial catalog or database in the data source.";
public const string DbConnectionString_FailoverPartner = @"The name or network address of the instance of SQL Server that acts as a failover partner.";
public const string DbConnectionString_IntegratedSecurity = @"Whether the connection is to be a secure connection or not.";
public const string DbConnectionString_LoadBalanceTimeout = @"The minimum amount of time (in seconds) for this connection to live in the pool before being destroyed.";
public const string DbConnectionString_MaxPoolSize = @"The maximum number of connections allowed in the pool.";
public const string DbConnectionString_MinPoolSize = @"The minimum number of connections allowed in the pool.";
public const string DbConnectionString_MultipleActiveResultSets = @"When true, multiple result sets can be returned and read from one connection.";
public const string DbConnectionString_MultiSubnetFailover = @"If your application is connecting to a high-availability, disaster recovery (AlwaysOn) availability group (AG) on different subnets, MultiSubnetFailover=Yes configures SqlConnection to provide faster detection of and connection to the (currently) active server.";
public const string DbConnectionString_NetworkLibrary = @"The network library used to establish a connection to an instance of SQL Server.";
public const string DbConnectionString_PacketSize = @"Size in bytes of the network packets used to communicate with an instance of SQL Server.";
public const string DbConnectionString_Password = @"Indicates the password to be used when connecting to the data source.";
public const string DbConnectionString_PersistSecurityInfo = @"When false, security-sensitive information, such as the password, is not returned as part of the connection if the connection is open or has ever been in an open state.";
public const string DbConnectionString_Pooling = @"When true, the connection object is drawn from the appropriate pool, or if necessary, is created and added to the appropriate pool.";
public const string DbConnectionString_Replication = @"Used by SQL Server in Replication.";
public const string DbConnectionString_TransactionBinding = @"Indicates binding behavior of connection to a System.Transactions Transaction when enlisted.";
public const string DbConnectionString_TrustServerCertificate = @"When true (and encrypt=true), SQL Server uses SSL encryption for all data sent between the client and server without validating the server certificate.";
public const string DbConnectionString_TypeSystemVersion = @"Indicates which server type system the provider will expose through the DataReader.";
public const string DbConnectionString_UserID = @"Indicates the user ID to be used when connecting to the data source.";
public const string DbConnectionString_UserInstance = @"Indicates whether the connection will be re-directed to connect to an instance of SQL Server running under the user's account.";
public const string DbConnectionString_WorkstationID = @"The name of the workstation connecting to SQL Server.";
public const string DbConnectionString_ApplicationIntent = @"Declares the application workload type when connecting to a server.";

public const string DbConnectionString_ConnectRetryCount = @"Number of attempts to restore connection.";
public const string DbConnectionString_ConnectRetryInterval = @"Delay between attempts to restore connection.";




public const string OdbcConnection_ConnectionString = @"Information used to connect to a Data Source.";
public const string OdbcConnection_ConnectionTimeout = @"Current connection timeout value, not settable in the ConnectionString.";
public const string OdbcConnection_Database = @"Current data source catalog value, 'Database=X' in the connection string.";
public const string OdbcConnection_DataSource = @"Current data source, 'Server=X' in the connection string.";
public const string OdbcConnection_Driver = @"Current ODBC driver.";
public const string OdbcConnection_ServerVersion = @"Version of the product accessed by the ODBC Driver.";

public const string OleDbConnection_ConnectionString = @"Information used to connect to a Data Source.";
public const string OleDbConnection_ConnectionTimeout = @"Current connection timeout value, 'Connect Timeout=X' in the ConnectionString.";
public const string OleDbConnection_Database = @"Current data source catalog value, 'Initial Catalog=X' in the connection string.";
public const string OleDbConnection_DataSource = @"Current data source, 'Data Source=X' in the connection string.";
public const string OleDbConnection_Provider = @"Current OLE DB provider ProgID, 'Provider=X' in the connection string.";
public const string OleDbConnection_ServerVersion = @"Version of the product accessed by the OLE DB Provider.";

public const string SqlConnection_Asynchronous = @"State of connection, synchronous or asynchronous.  'Asynchronous Processing=x' in the connection string.";
public const string SqlConnection_Replication = @"Information used to connect for replication.";
public const string SqlConnection_ConnectionString = @"Information used to connect to a DataSource, such as 'Data Source=x;Initial Catalog=x;Integrated Security=SSPI'.";
public const string SqlConnection_ConnectionTimeout = @"Current connection timeout value, 'Connect Timeout=X' in the ConnectionString.";
public const string SqlConnection_Database = @"Current SQL Server database, 'Initial Catalog=X' in the connection string.";
public const string SqlConnection_DataSource = @"Current SqlServer that the connection is opened to, 'Data Source=X' in the connection string.";
public const string SqlConnection_PacketSize = @"Network packet size, 'Packet Size=x' in the connection string.";
public const string SqlConnection_ServerVersion = @"Version of the SQL Server accessed by the SqlConnection.";
public const string SqlConnection_WorkstationId = @"Workstation Id, 'Workstation ID=x' in the connection string.";
public const string SqlConnection_StatisticsEnabled = @"Collect statistics for this connection.";
public const string SqlConnection_ClientConnectionId = @"A guid to represent the physical connection.";
public const string SqlConnection_Credential = @"User Id and secure password to use for authentication.";


public const string DbConnection_InfoMessage = @"Event triggered when messages arrive from the DataSource.";





public const string DbCommand_CommandText = @"Command text to execute.";

public const string DbCommand_CommandType = @"How to interpret the CommandText.";
public const string DbCommand_Connection = @"Connection used by the command.";
public const string DbCommand_Parameters = @"The parameters collection.";
public const string DbCommand_Transaction = @"The transaction used by the command.";
public const string DbCommand_UpdatedRowSource = @"When used by a DataAdapter.Update, how command results are applied to the current DataRow.";
public const string DbCommand_StatementCompleted = @"When records are affected by a given statement by the execution of the command.";

public const string SqlCommand_Notification = @"Notification values used by Microsoft SQL Server.";
public const string SqlCommand_NotificationAutoEnlist = @"Automatic enlistment in notifications used by Microsoft SQL Server.";


public const string DbCommandBuilder_ConflictOption = @"How the where clause is auto-generated for the Update and Delete commands when not specified by the user.";
public const string DbCommandBuilder_CatalogLocation = @"Indicates the position of the catalog name in a qualified table name in a text command.";
public const string DbCommandBuilder_CatalogSeparator = @"The character that separates the catalog name from the rest of the identifier in a text command.";
public const string DbCommandBuilder_SchemaSeparator = @"The character that separates the schema name from the rest of the identifier in a text command.";
public const string DbCommandBuilder_QuotePrefix = @"The prefix string wrapped around sql objects.";
public const string DbCommandBuilder_QuoteSuffix = @"The suffix string wrapped around sql objects.";
public const string DbCommandBuilder_DataAdapter = @"The DataAdapter for which to automatically generate Commands.";
public const string DbCommandBuilder_SchemaLocation = @"Use schema from DataTable or the SelectCommand.";
public const string DbCommandBuilder_SetAllValues = @"How the set clause is auto-generated for the Update command when not specified by the user.";

public const string OdbcCommandBuilder_DataAdapter = @"The DataAdapter for which to automatically generate OdbcCommands";
public const string OdbcCommandBuilder_QuotePrefix = @"The character used in a text command as the opening quote for quoting identifiers that contain special characters.";
public const string OdbcCommandBuilder_QuoteSuffix = @"The character used in a text command as the closing quote for quoting identifiers that contain special characters.";

public const string OleDbCommandBuilder_DataAdapter = @"The DataAdapter for which to automatically generate OleDbCommands";
public const string OleDbCommandBuilder_DecimalSeparator = @"The decimal separator used in numeric literals.";
public const string OleDbCommandBuilder_QuotePrefix = @"The prefix string wrapped around sql objects";
public const string OleDbCommandBuilder_QuoteSuffix = @"The suffix string wrapped around sql objects";

public const string SqlCommandBuilder_DataAdapter = @"The DataAdapter for which to automatically generate SqlCommands";
public const string SqlCommandBuilder_DecimalSeparator = @"The decimal separator used in numeric literals.";
public const string SqlCommandBuilder_QuotePrefix = @"The character used in a text command as the opening quote for quoting identifiers that contain special characters.";
public const string SqlCommandBuilder_QuoteSuffix = @"The character used in a text command as the closing quote for quoting identifiers that contain special characters.";












public const string DbDataParameter_Precision = @"Only necessary to set for decimal and numeric parameters when using with Prepare, FillSchema and CommandBuilder scenarios.";
public const string DbDataParameter_Scale = @"Only necessary to set for decimal and numeric parameters when using with Prepare, FillSchema and CommandBuilder scenarios.";



public const string OdbcParameter_OdbcType = @"The parameter native type.";

public const string OleDbParameter_OleDbType = @"The parameter native type.";

public const string SqlParameter_ParameterName = @"Name of the parameter, like '@p1'";
public const string SqlParameter_SqlDbType = @"The parameter native type.";
public const string SqlParameter_TypeName = @"The server's name for the type.";
public const string SqlParameter_Offset = @"Offset in variable length data types.";
public const string SqlParameter_XmlSchemaCollectionDatabase = @"XmlSchemaCollectionDatabase";
public const string SqlParameter_XmlSchemaCollectionOwningSchema = @"XmlSchemaCollectionOwningSchema";
public const string SqlParameter_XmlSchemaCollectionName = @"XmlSchemaCollectionName";
public const string SqlParameter_UnsupportedTVPOutputParameter = @"ParameterDirection '{0}' specified for parameter '{1}' is not supported. Table-valued parameters only support ParameterDirection.Input.";
public const string SqlParameter_DBNullNotSupportedForTVP = @"DBNull value for parameter '{0}' is not supported. Table-valued parameters cannot be DBNull.";
public const string SqlParameter_InvalidTableDerivedPrecisionForTvp = @"Precision '{0}' required to send all values in column '{1}' exceeds the maximum supported precision '{2}'. The values must all fit in a single precision.";
public const string SqlParameter_UnexpectedTypeNameForNonStruct = @"TypeName specified for parameter '{0}'.  TypeName must only be set for Structured parameters.";
public const string MetaType_SingleValuedStructNotSupported = @"SqlDbType.Structured type is only supported for multiple valued types.";
public const string NullSchemaTableDataTypeNotSupported = @"DateType column for field '{0}' in schema table is null.  DataType must be non-null.";
public const string InvalidSchemaTableOrdinals = @"Invalid column ordinals in schema table.  ColumnOrdinals, if present, must not have duplicates or gaps.";
public const string SQL_EnumeratedRecordMetaDataChanged = @"Metadata for field '{0}' of record '{1}' did not match the original record's metadata.";
public const string SQL_EnumeratedRecordFieldCountChanged = @"Number of fields in record '{0}' does not match the number in the original record.";




public const string SQLUDT_MaxByteSizeValue = @"range: 0-8000";

public const string SQLUDT_Unexpected = @"unexpected error encountered in SqlClient data provider. {0}";
public const string SQLUDT_InvalidDbId = @"Unable to get Type Info for {0},{1}";
public const string SQLUDT_CantLoadAssembly = @"The provider has failed to load the following assembly: {0}";
public const string SQLUDT_InvalidUdtTypeName = @"UdtTypeName property must be set for UDT parameters.";


public const string SQLUDT_UnexpectedUdtTypeName = @"UdtTypeName property must be set only for UDT parameters.";
public const string SQLUDT_InvalidSqlType = @"Specified type is not registered on the target server.{0}.";
public const string SQLUDT_InWhereClause = @"UDT parameters not permitted in the where clause unless part of the primary key.";

public const string SqlUdt_InvalidUdtMessage = @"'{0}' is an invalid user defined type, reason: {1}.";
public const string SqlUdtReason_MultipleSerFormats = @"supports both in-memory and user-defined formats";
public const string SqlUdtReason_CannotSupportNative = @"Native format can't be supported.";
public const string SqlUdtReason_CannotSupportUserDefined = @"does not implement IBinarySerialize";
public const string SqlUdtReason_NotSerializable = @"not serializable";
public const string SqlUdtReason_NoPublicConstructors = @"no public constructors";
public const string SqlUdtReason_NotNullable = @"does not implement INullable";
public const string SqlUdtReason_NoPublicConstructor = @"does not have a public constructor";
public const string SqlUdtReason_NoUdtAttribute = @"no UDT attribute";
public const string SqlUdtReason_MaplessNotYetSupported = @"Serialization without mapping is not yet supported.";
public const string SqlUdtReason_ParseMethodMissing = @"'public static x Parse(System.Data.SqlTypes.SqlString)' method is missing";
public const string SqlUdtReason_ToStringMethodMissing = @"'public override string ToString()' method is missing";
public const string SqlUdtReason_NullPropertyMissing = @"'public static x Null { get; }' method is missing";
public const string SqlUdtReason_NativeFormatNoFieldSupport = @"Native format does not support fields (directly or through another field) of type '{0}'";
public const string SqlUdtReason_TypeNotPublic = @"Type is not public";
public const string SqlUdtReason_NativeUdtNotSequentialLayout = @"Native UDT not sequential layout due to type '{0}'";
public const string SqlUdtReason_NativeUdtMaxByteSize = @"Native UDT specifies a max byte size";
public const string SqlUdtReason_NonSerializableField = @"field '{0}' is marked non-serialized";
public const string SqlUdtReason_NativeFormatExplictLayoutNotAllowed = @"The type of field '{0}' is marked as explicit layout which is not allowed in Native format";
public const string SqlUdtReason_MultivaluedAssemblyId = @"Multiple valued assembly references must have a nonzero Assembly Id.";



public const string SQLTVP_TableTypeCanOnlyBeParameter = @"Structured, multiple-valued types can only be used for parameters, and cannot be nested within another type.";



public const string SqlFileStream_InvalidPath = @"The path name is not valid.";
public const string SqlFileStream_InvalidParameter = @"An invalid parameter was passed to the function.";
public const string SqlFileStream_FileAlreadyInTransaction = @"The process cannot access the file specified because it has been opened in another transaction.";
public const string SqlFileStream_PathNotValidDiskResource = @"The path name is invalid or does not point to a disk file.";



public const string SqlDelegatedTransaction_PromotionFailed = @"Failure while attempting to promote transaction.";





public const string SqlDependency_SqlDependency = @"Dependency object used to receive query notifications.";
public const string SqlDependency_HasChanges = @"Property to indicate if this dependency is invalid.";
public const string SqlDependency_Id = @"A string that uniquely identifies this dependency object.";
public const string SqlDependency_OnChange = @"Event that can be used to subscribe for change notifications.";
public const string SqlDependency_AddCommandDependency = @"To add a command to existing dependency object.";
public const string SqlDependency_Duplicate = @"Command is already associated with another dependency object. Can not overwrite.";



public const string SQLNotify_AlreadyHasCommand = @"This SqlCommand object is already associated with another SqlDependency object.";
public const string SqlNotify_SqlDepCannotBeCreatedInProc = @"SqlDependency object cannot be created when running inside the SQL Server process.";

public const string SqlDependency_DatabaseBrokerDisabled = @"The SQL Server Service Broker for the current database is not enabled, and as a result query notifications are not supported.  Please enable the Service Broker for this database if you wish to use notifications.";
public const string SqlDependency_DefaultOptionsButNoStart = @"When using SqlDependency without providing an options value, SqlDependency.Start() must be called prior to execution of a command added to the SqlDependency instance.";
public const string SqlDependency_EventNoDuplicate = @"SqlDependency.OnChange does not support multiple event registrations for the same delegate.";
public const string SqlDependency_DuplicateStart = @"SqlDependency does not support calling Start() with different connection strings having the same server, user, and database in the same app domain.";
public const string SqlDependency_IdMismatch = @"No SqlDependency exists for the key.";
public const string SqlDependency_NoMatchingServerStart = @"When using SqlDependency without providing an options value, SqlDependency.Start() must be called for each server that is being executed against.";
public const string SqlDependency_NoMatchingServerDatabaseStart = @"SqlDependency.Start has been called for the server the command is executing against more than once, but there is no matching server/user/database Start() call for current command.";
public const string SqlDependency_InvalidTimeout = @"Timeout specified is invalid. Timeout cannot be < 0.";
public const string SQLNotify_ErrorFormat = @"Notification Error. Type={0}, Info={1}, Source={2}.";




public const string SqlMetaData_NoMetadata = @"GetMetaData is not valid for this SqlDbType.";
public const string SqlMetaData_InvalidSqlDbTypeForConstructorFormat = @"The dbType {0} is invalid for this constructor.";
public const string SqlMetaData_NameTooLong = @"The name is too long.";
public const string SqlMetaData_SpecifyBothSortOrderAndOrdinal = @"The sort order and ordinal must either both be specified, or neither should be specified (SortOrder.Unspecified and -1).  The values given were: order = {0}, ordinal = {1}.";
public const string SqlProvider_InvalidDataColumnType = @"The type of column '{0}' is not supported.  The type is '{1}'";
public const string SqlProvider_InvalidDataColumnMaxLength = @"The size of column '{0}' is not supported. The size is {1}.";
public const string SqlProvider_NotEnoughColumnsInStructuredType = @"There are not enough fields in the Structured type.  Structured types must have at least one field.";
public const string SqlProvider_DuplicateSortOrdinal = @"The sort ordinal {0} was specified twice.";
public const string SqlProvider_MissingSortOrdinal = @"The sort ordinal {0} was not specified.";
public const string SqlProvider_SortOrdinalGreaterThanFieldCount = @"The sort ordinal {0} on field {1} exceeds the total number of fields.";
public const string IEnumerableOfSqlDataRecordHasNoRows = @"There are no records in the SqlDataRecord enumeration. To send a table-valued parameter with no rows, use a null reference for the value instead.";


public const string SqlPipe_CommandHookedUpToNonContextConnection = @"SqlPipe does not support executing a command with a connection that is not a context connection.";
public const string SqlPipe_MessageTooLong = @"Message length {0} exceeds maximum length supported of 4000.";
public const string SqlPipe_IsBusy = @"Could not use the pipe while it is busy with another operation.";
public const string SqlPipe_AlreadyHasAnOpenResultSet = @"A result set is currently being sent to the pipe. End the current result set before calling {0}.";
public const string SqlPipe_DoesNotHaveAnOpenResultSet = @"Result set has not been initiated.  Call SendResultSetStart before calling {0}.";



public const string SNI_PN0 = @"HTTP Provider";
public const string SNI_PN1 = @"Named Pipes Provider";
public const string SNI_PN2 = @"Session Provider";
public const string SNI_PN3 = @"Sign Provider";
public const string SNI_PN4 = @"Shared Memory Provider";
public const string SNI_PN5 = @"SMux Provider";
public const string SNI_PN6 = @"SSL Provider";
public const string SNI_PN7 = @"TCP Provider";
public const string SNI_PN8 = @"VIA Provider";
public const string SNI_PN9 = @"";
public const string SNI_PN10 = @"SQL Network Interfaces";


public const string SNI_ERROR_1 = @"I/O Error detected in read/write operation";
public const string SNI_ERROR_2 = @"Connection was terminated";
public const string SNI_ERROR_3 = @"Asynchronous operations not supported";
public const string SNI_ERROR_4 = @"";
public const string SNI_ERROR_5 = @"Invalid parameter(s) found";
public const string SNI_ERROR_6 = @"Unsupported protocol specified";
public const string SNI_ERROR_7 = @"Invalid connection found when setting up new session protocol";
public const string SNI_ERROR_8 = @"Protocol not supported";
public const string SNI_ERROR_9 = @"Associating port with I/O completion mechanism failed";
public const string SNI_ERROR_10 = @"";
public const string SNI_ERROR_11 = @"Timeout error";
public const string SNI_ERROR_12 = @"No server name supplied";
public const string SNI_ERROR_13 = @"TerminateListener() has been called";
public const string SNI_ERROR_14 = @"Win9x not supported";
public const string SNI_ERROR_15 = @"Function not supported";
public const string SNI_ERROR_16 = @"Shared-Memory heap error";
public const string SNI_ERROR_17 = @"Cannot find an ip/ipv6 type address to connect";
public const string SNI_ERROR_18 = @"Connection has been closed by peer";
public const string SNI_ERROR_19 = @"Physical connection is not usable";
public const string SNI_ERROR_20 = @"Connection has been closed";
public const string SNI_ERROR_21 = @"Encryption is enforced but there is no valid certificate";
public const string SNI_ERROR_22 = @"Couldn't load library";
public const string SNI_ERROR_23 = @"Cannot open a new thread in server process";
public const string SNI_ERROR_24 = @"Cannot post event to completion port";
public const string SNI_ERROR_25 = @"Connection string is not valid";
public const string SNI_ERROR_26 = @"Error Locating Server/Instance Specified";
public const string SNI_ERROR_27 = @"Error getting enabled protocols list from registry";
public const string SNI_ERROR_28 = @"Server doesn't support requested protocol";
public const string SNI_ERROR_29 = @"Shared Memory is not supported for clustered server connectivity";
public const string SNI_ERROR_30 = @"Invalid attempt bind to shared memory segment";
public const string SNI_ERROR_31 = @"Encryption(ssl/tls) handshake failed";
public const string SNI_ERROR_32 = @"Packet size too large for SSL Encrypt/Decrypt operations";
public const string SNI_ERROR_33 = @"SSRP error";
public const string SNI_ERROR_34 = @"Could not connect to the Shared Memory pipe";
public const string SNI_ERROR_35 = @"An internal exception was caught";
public const string SNI_ERROR_36 = @"The Shared Memory dll used to connect to SQL Server 2000 was not found";
public const string SNI_ERROR_37 = @"The SQL Server 2000 Shared Memory client dll appears to be invalid/corrupted";
public const string SNI_ERROR_38 = @"Cannot open a Shared Memory connection to SQL Server 2000";
public const string SNI_ERROR_39 = @"Shared memory connectivity to SQL Server 2000 is either disabled or not available on this machine";
public const string SNI_ERROR_40 = @"Could not open a connection to SQL Server";
public const string SNI_ERROR_41 = @"Cannot open a Shared Memory connection to a remote SQL server";
public const string SNI_ERROR_42 = @"Could not establish dedicated administrator connection (DAC) on default port. Make sure that DAC is enabled";
public const string SNI_ERROR_43 = @"An error occurred while obtaining the dedicated administrator connection (DAC) port. Make sure that SQL Browser is running, or check the error log for the port number";
public const string SNI_ERROR_44 = @"Could not compose Service Principal Name (SPN) for Windows Integrated Authentication. Possible causes are server(s) incorrectly specified to connection API calls, Domain Name System (DNS) lookup failure or memory shortage";






public const string SNI_ERROR_47 = @"Connecting with the MultiSubnetFailover connection option to a SQL Server instance configured with more than 64 IP addresses is not supported.";
public const string SNI_ERROR_48 = @"Connecting to a named SQL Server instance using the MultiSubnetFailover connection option is not supported.";
public const string SNI_ERROR_49 = @"Connecting to a SQL Server instance using the MultiSubnetFailover connection option is only supported when using the TCP protocol.";


public const string SNI_ERROR_50 = @"Local Database Runtime error occurred. ";
public const string SNI_ERROR_51 = @"An instance name was not specified while connecting to a Local Database Runtime. Specify an instance name in the format (localdb)\\instance_name.";
public const string SNI_ERROR_52 = @"Unable to locate a Local Database Runtime installation. Verify that SQL Server Express is properly installed and that the Local Database Runtime feature is enabled.";
public const string SNI_ERROR_53 = @"Invalid Local Database Runtime registry configuration found. Verify that SQL Server Express is properly installed.";
public const string SNI_ERROR_54 = @"Unable to locate the registry entry for SQLUserInstance.dll file path. Verify that the Local Database Runtime feature of SQL Server Express is properly installed.";
public const string SNI_ERROR_55 = @"Registry value contains an invalid SQLUserInstance.dll file path. Verify that the Local Database Runtime feature of SQL Server Express is properly installed.";
public const string SNI_ERROR_56 = @"Unable to load the SQLUserInstance.dll from the location specified in the registry. Verify that the Local Database Runtime feature of SQL Server Express is properly installed.";
public const string SNI_ERROR_57 = @"Invalid SQLUserInstance.dll found at the location specified in the registry. Verify that the Local Database Runtime feature of SQL Server Express is properly installed.";


public const string Snix_Connect = @"A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections.";
public const string Snix_PreLoginBeforeSuccessfullWrite = @"The client was unable to establish a connection because of an error during connection initialization process before login. Possible causes include the following:  the client tried to connect to an unsupported version of SQL Server; the server was too busy to accept new connections; or there was a resource limitation (insufficient memory or maximum allowed connections) on the server.";
public const string Snix_PreLogin = @"A connection was successfully established with the server, but then an error occurred during the pre-login handshake.";
public const string Snix_LoginSspi = @"A connection was successfully established with the server, but then an error occurred when obtaining the security/SSPI context information for integrated security login.";
public const string Snix_Login = @"A connection was successfully established with the server, but then an error occurred during the login process.";
public const string Snix_EnableMars = @"Connection open and login was successful, but then an error occurred while enabling MARS for this connection.";
public const string Snix_AutoEnlist = @"Connection open and login was successful, but then an error occurred while enlisting the connection into the current distributed transaction.";
public const string Snix_GetMarsSession = @"Failed to establish a MARS session in preparation to send the request to the server.";
public const string Snix_Execute = @"A transport-level error has occurred when sending the request to the server.";
public const string Snix_Read = @"A transport-level error has occurred when receiving results from the server.";
public const string Snix_Close = @"A transport-level error has occurred during connection clean-up.";
public const string Snix_SendRows = @"A transport-level error has occurred while sending information to the server.";
public const string Snix_ProcessSspi = @"A transport-level error has occured during SSPI handshake.";


public const string LocalDB_CreateFailed = @"Local Database Runtime: Cannot create named instance.";
public const string LocalDB_BadConfigSectionType = @"Local Database Runtime: system.data.localdb configuration file section is of unknown type.";
public const string LocalDB_FailedGetDLLHandle = @"Local Database Runtime: Cannot load SQLUserInstance.dll.";
public const string LocalDB_MethodNotFound = @"Invalid SQLUserInstance.dll found at the location specified in the registry. Verify that the Local Database Runtime feature of SQL Server Express is properly installed.";
public const string LocalDB_UnobtainableMessage = @"Cannot obtain Local Database Runtime error message";
public const string LocalDB_InvalidVersion = @"Local Database Runtime: Invalid instance version specification found in the configuration file.";


public const string SQLROR_RecursiveRoutingNotSupported = @"Two or more redirections have occurred. Only one redirection per login is allowed.";
public const string SQLROR_FailoverNotSupported = @"Connecting to a mirrored SQL Server instance using the ApplicationIntent ReadOnly connection option is not supported.";
public const string SQLROR_UnexpectedRoutingInfo = @"Unexpected routing information received.";
public const string SQLROR_InvalidRoutingInfo = @"Invalid routing information received.";
public const string SQLROR_TimeoutAfterRoutingInfo = @"Server provided routing information, but timeout already expired.";


public const string SQLCR_InvalidConnectRetryCountValue = @"Invalid ConnectRetryCount value (should be 0-255).";
public const string SQLCR_InvalidConnectRetryIntervalValue = @"Invalid ConnectRetryInterval value (should be 1-60).";
public const string SQLCR_NextAttemptWillExceedQueryTimeout = @"Next reconnection attempt will exceed query timeout. Reconnection was terminated.";
public const string SQLCR_EncryptionChanged = @"The server did not preserve SSL encryption during a recovery attempt, connection recovery is not possible.";
public const string SQLCR_TDSVestionNotPreserved = @"The server did not preserve the exact client TDS version requested during a recovery attempt, connection recovery is not possible.";
public const string SQLCR_AllAttemptsFailed = @"The connection is broken and recovery is not possible.  The client driver attempted to recover the connection one or more times and all attempts failed.  Increase the value of ConnectRetryCount to increase the number of recovery attempts.";
public const string SQLCR_UnrecoverableServer = @"The connection is broken and recovery is not possible.  The connection is marked by the server as unrecoverable.  No attempt was made to restore the connection.";
public const string SQLCR_UnrecoverableClient = @"The connection is broken and recovery is not possible.  The connection is marked by the client driver as unrecoverable.  No attempt was made to restore the connection.";
public const string SQLCR_NoCRAckAtReconnection = @"The server did not acknowledge a recovery attempt, connection recovery is not possible.";
       public static string GetString (string name)
       {
               return SR.GetString (name);
       }

       public static string GetString (string name, params object[] args)
       {
               return SR.GetString (name, args);
       }

}
}