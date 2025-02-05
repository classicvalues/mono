#! -*- makefile -*-

BOOTSTRAP_PROFILE = build

BOOTSTRAP_MCS = MONO_PATH="$(topdir)/class/lib/$(BOOTSTRAP_PROFILE)$(PLATFORM_PATH_SEPARATOR)$$MONO_PATH" $(INTERNAL_CSC)
MCS = $(BOOTSTRAP_MCS)

PLATFORMS = win32 linux macos

profile-check:
	@:

DEFAULT_REFERENCES = mscorlib

ifeq ($(HOST_PLATFORM),win32)
	PLATFORM_FLAGS = -d:WIN_PLATFORM -d:WINAOT
endif

ifeq ($(HOST_PLATFORM),linux)
	PROFILE_DISABLE_BTLS = yes
endif

PROFILE_MCS_FLAGS = \
	-d:NET_1_1 \
	-d:NET_2_0 \
	-d:NET_2_1 \
	-d:NET_3_5 \
	-d:NET_4_0 \
	-d:NET_4_5 \
	-d:MONO \
	-d:UNITY \
	-d:UNITY_AOT \
	-d:MOBILE,MOBILE_LEGACY \
	-d:FULL_AOT_DESKTOP	\
	-d:FULL_AOT_RUNTIME \
	$(PLATFORM_FLAGS) \
	-nowarn:1699 \
	-nostdlib \
	$(PLATFORM_DEBUG_FLAGS)

API_BIN_PROFILE = v4.7.1
FRAMEWORK_VERSION = 2.1

NO_INSTALL = yes
AOT_FRIENDLY_PROFILE = yes
ALWAYS_AOT_BCL = yes
MOBILE_PROFILE = yes
NO_SRE = yes

ifeq ($(HOST_PLATFORM),macos)
PROFILE_MCS_FLAGS += -d:DISABLE_COM
endif

ifeq ($(HOST_PLATFORM),linux)
PROFILE_MCS_FLAGS += -d:DISABLE_COM
endif
