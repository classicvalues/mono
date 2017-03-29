//
// This file was generated by resx2sr tool
//

partial class SR
{
	public const string BlockingCollection_Add_ConcurrentCompleteAdd = "CompleteAdding may not be used concurrently with additions to the collection.";
	public const string BlockingCollection_Add_Failed = "The underlying collection didn't accept the item.";
	public const string BlockingCollection_CantAddAnyWhenCompleted = "At least one of the specified collections is marked as complete with regards to additions.";
	public const string BlockingCollection_CantTakeAnyWhenAllDone = "All collections are marked as complete with regards to additions.";
	public const string BlockingCollection_CantTakeWhenDone = "The collection argument is empty and has been marked as complete with regards to additions.";
	public const string BlockingCollection_Completed = "The collection has been marked as complete with regards to additions.";
	public const string BlockingCollection_CopyTo_IncorrectType = "The array argument is of the incorrect type.";
	public const string BlockingCollection_CopyTo_MultiDim = "The array argument is multidimensional.";
	public const string BlockingCollection_CopyTo_NonNegative = "The index argument must be greater than or equal zero.";
	public const string Collection_CopyTo_TooManyElems = "The number of elements in the collection is greater than the available space from index to the end of the destination array.";
	public const string BlockingCollection_ctor_BoundedCapacityRange = "The boundedCapacity argument must be positive.";
	public const string BlockingCollection_ctor_CountMoreThanCapacity = "The collection argument contains more items than are allowed by the boundedCapacity.";
	public const string BlockingCollection_Disposed = "The collection has been disposed.";
	public const string BlockingCollection_Take_CollectionModified = "The underlying collection was modified from outside of the BlockingCollection<T>.";
	public const string BlockingCollection_TimeoutInvalid = "The specified timeout must represent a value between -1 and {0}, inclusive.";
	public const string BlockingCollection_ValidateCollectionsArray_DispElems = "The collections argument contains at least one disposed element.";
	public const string BlockingCollection_ValidateCollectionsArray_LargeSize = "The collections length is greater than the supported range for 32 bit machine.";
	public const string BlockingCollection_ValidateCollectionsArray_NullElems = "The collections argument contains at least one null element.";
	public const string BlockingCollection_ValidateCollectionsArray_ZeroSize = "The collections argument is a zero-length array.";
	public const string Common_OperationCanceled = "The operation was canceled.";
	public const string ConcurrentBag_Ctor_ArgumentNullException = "The collection argument is null.";
	public const string ConcurrentBag_CopyTo_ArgumentNullException = "The array argument is null.";
	public const string Collection_CopyTo_ArgumentOutOfRangeException = "The index argument must be greater than or equal zero.";
	public const string ConcurrentCollection_SyncRoot_NotSupported = "The SyncRoot property may not be used for the synchronization of concurrent collections.";
	public const string ConcurrentDictionary_ArrayIncorrectType = "The array is multidimensional, or the type parameter for the set cannot be cast automatically to the type of the destination array.";
	public const string ConcurrentDictionary_SourceContainsDuplicateKeys = "The source argument contains duplicate keys.";
	public const string ConcurrentDictionary_ConcurrencyLevelMustBePositive = "The concurrencyLevel argument must be positive.";
	public const string ConcurrentDictionary_CapacityMustNotBeNegative = "The capacity argument must be greater than or equal to zero.";
	public const string ConcurrentDictionary_IndexIsNegative = "The index argument is less than zero.";
	public const string ConcurrentDictionary_ArrayNotLargeEnough = "The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.";
	public const string ConcurrentDictionary_KeyAlreadyExisted = "The key already existed in the dictionary.";
	public const string ConcurrentDictionary_ItemKeyIsNull = "TKey is a reference type and item.Key is null.";
	public const string ConcurrentDictionary_TypeOfKeyIncorrect = "The key was of an incorrect type for this dictionary.";
	public const string ConcurrentDictionary_TypeOfValueIncorrect = "The value was of an incorrect type for this dictionary.";
	public const string ConcurrentStack_PushPopRange_CountOutOfRange = "The count argument must be greater than or equal to zero.";
	public const string ConcurrentStack_PushPopRange_InvalidCount = "The sum of the startIndex and count arguments must be less than or equal to the collection's Count.";
	public const string ConcurrentStack_PushPopRange_StartOutOfRange = "The startIndex argument must be greater than or equal to zero.";
	public const string Partitioner_DynamicPartitionsNotSupported = "Dynamic partitions are not supported by this partitioner.";
	public const string PartitionerStatic_CanNotCallGetEnumeratorAfterSourceHasBeenDisposed = "Can not call GetEnumerator on partitions after the source enumerable is disposed";
	public const string PartitionerStatic_CurrentCalledBeforeMoveNext = "MoveNext must be called at least once before calling Current.";
	public const string ConcurrentBag_Enumerator_EnumerationNotStartedOrAlreadyFinished = "Enumeration has either not started or has already finished.";
	public const string Arg_NonZeroLowerBound = "The lower bound of target array must be zero.";
	public const string Arg_WrongType = "The value '{0}' is not of type '{1}' and cannot be used in this generic collection.";
	public const string Arg_ArrayPlusOffTooSmall = "Destination array is not long enough to copy all the items in the collection. Check array index and length.";
	public const string ArgumentOutOfRange_NeedNonNegNum = "Non-negative number required.";
	public const string ArgumentOutOfRange_SmallCapacity = "capacity was less than the current size.";
	public const string Argument_InvalidOffLen = "Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.";
	public const string Argument_AddingDuplicate = "An item with the same key has already been added. Key: {0}";
	public const string InvalidOperation_EmptyQueue = "Queue empty.";
	public const string InvalidOperation_EnumOpCantHappen = "Enumeration has either not started or has already finished.";
	public const string InvalidOperation_EnumFailedVersion = "Collection was modified; enumeration operation may not execute.";
	public const string InvalidOperation_EmptyStack = "Stack empty.";
	public const string InvalidOperation_EnumNotStarted = "Enumeration has not started. Call MoveNext.";
	public const string InvalidOperation_EnumEnded = "Enumeration already finished.";
	public const string NotSupported_KeyCollectionSet = "Mutating a key collection derived from a dictionary is not allowed.";
	public const string NotSupported_ValueCollectionSet = "Mutating a value collection derived from a dictionary is not allowed.";
	public const string Arg_ArrayLengthsDiffer = "Array lengths must be the same.";
	public const string Arg_BitArrayTypeUnsupported = "Only supported array types for CopyTo on BitArrays are Boolean[], Int32[] and Byte[].";
	public const string Arg_HSCapacityOverflow = "HashSet capacity is too big.";
	public const string Arg_HTCapacityOverflow = "Hashtable's capacity overflowed and went negative. Check load factor, capacity and the current size of the table.";
	public const string Arg_InsufficientSpace = "Insufficient space in the target location to copy the information.";
	public const string Arg_RankMultiDimNotSupported = "Only single dimensional arrays are supported for the requested action.";
	public const string Argument_ArrayTooLarge = "The input array length must not exceed Int32.MaxValue / {0}. Otherwise BitArray.Length would exceed Int32.MaxValue.";
	public const string Argument_InvalidArrayType = "Target array type is not compatible with the type of items in the collection.";
	public const string ArgumentOutOfRange_BiggerThanCollection = "Must be less than or equal to the size of the collection.";
	public const string ArgumentOutOfRange_Index = "Index was out of range. Must be non-negative and less than the size of the collection.";
	public const string ExternalLinkedListNode = "The LinkedList node does not belong to current LinkedList.";
	public const string LinkedListEmpty = "The LinkedList is empty.";
	public const string LinkedListNodeIsAttached = "The LinkedList node already belongs to a LinkedList.";
	public const string NotSupported_SortedListNestedWrite = "This operation is not supported on SortedList nested types because they require modifying the original SortedList.";
	public const string SortedSet_LowerValueGreaterThanUpperValue = "Must be less than or equal to upperValue.";
	public const string Serialization_InvalidOnDeser = "OnDeserialization method was called while the object was not being deserialized.";
	public const string Serialization_MismatchedCount = "The serialized Count information doesn't match the number of items.";
	public const string Serialization_MissingKeys = "The keys for this dictionary are missing.";
	public const string Serialization_MissingValues = "The values for this dictionary are missing.";
	public const string ArgumentException_BufferNotFromPool = "The buffer is not associated with this pool and may not be returned to it.";
}
