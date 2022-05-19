# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

import types

__config__ = pulumi.Config('mssql')


class _ExportableConfig(types.ModuleType):
    @property
    def debug(self) -> Optional[bool]:
        """
        Enable provider debug logging (logs to file terraform-provider-mssql.log)
        """
        return __config__.get_bool('debug')
